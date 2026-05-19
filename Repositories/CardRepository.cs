using Bank.DB;
using Bank.Models;
using Npgsql;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class CardRepository : ICardRepository
{
        public Card Save(Card card)
        {
            using var conn = Db.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand(
                "INSERT INTO cards (account_id, user_id, card_number, cardholder_name, " +
                "expiry_date, cvv_hash, card_type, card_brand, is_active, daily_limit, " +
                "internet_enabled, pin_hash, created_at) " +
                "VALUES (@accountId, @userId, generate_card_number(), " +
                "(SELECT UPPER(name || ' ' || surname) FROM users WHERE id = @userId), " +
                "@expiryDate, encrypt_value(generate_cvv()), @cardType, @cardBrand, @isActive, @dailyLimit, " +
                "@internetEnabled, encrypt_value(generate_pin()), @createdAt) " +
                "RETURNING id, card_number, decrypt_value(pin_hash), decrypt_value(cvv_hash)", conn);

            cmd.Parameters.AddWithValue("@accountId", card.AccountId);
            cmd.Parameters.AddWithValue("@userId", card.UserId);
            cmd.Parameters.AddWithValue("@expiryDate", card.ExpiryDate);
            cmd.Parameters.AddWithValue("@cardType", card.CardType);
            cmd.Parameters.AddWithValue("@cardBrand", card.CardBrand);
            cmd.Parameters.AddWithValue("@isActive", card.IsActive);
            cmd.Parameters.AddWithValue("@dailyLimit", card.DailyLimit);
            cmd.Parameters.AddWithValue("@internetEnabled", card.InternetEnabled);
            cmd.Parameters.AddWithValue("@createdAt", card.CreatedAt);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                card.SetId(reader.GetInt32(0));
                card.SetCardNumber(reader.GetString(1));
                card.SetPinHash(reader.GetString(2));
                card.SetCvvHash(reader.GetString(3)); 
            }

            return card ;
        }

        public List<Card> GetByUserId(int userId)
        {
            List<Card> cards = new List<Card>();

            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using var cmd = new NpgsqlCommand(
                    "SELECT id, account_id, user_id, card_number, cardholder_name, " +
                    "expiry_date, card_type, card_brand, is_active, daily_limit, " +
                    "internet_enabled, decrypt_value(pin_hash), decrypt_value(cvv_hash), created_at " +
                    "FROM cards WHERE user_id = @userId", conn);
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Card card = new Card();
                            card.SetId(reader.GetInt32(0));
                            card.SetAccountId(reader.GetInt32(1));
                            card.SetUserId(reader.GetInt32(2));
                            card.SetCardNumber(reader.GetString(3));
                            card.SetCardholderName(reader.GetString(4));
                            card.SetExpiryDate(reader.GetDateTime(5));
                            card.SetCardType(reader.GetString(6));
                            card.SetCardBrand(reader.GetString(7));
                            if (reader.GetBoolean(8)) card.Activate();
                            card.SetDailyLimit(reader.GetDecimal(9));
                            if (reader.GetBoolean(10)) card.EnableInternet();
                            card.SetPinHash(reader.GetString(11));  
                            card.SetCvvHash(reader.GetString(12));
                            card.SetCreatedAt(reader.GetDateTime(13));
                            cards.Add(card);
                        }
                    }
                }
            }

            return cards;
        }

        public Card? GetById(int cardId)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT id, account_id, user_id, card_number, cardholder_name, " +
                    "expiry_date, card_type, card_brand, is_active, daily_limit, " +
                    "internet_enabled, decrypt_value(pin_hash), decrypt_value(cvv_hash), created_at " +
                    "FROM cards WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cardId);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        Card card = new Card();
                        card.SetId(reader.GetInt32(0));
                        card.SetAccountId(reader.GetInt32(1));
                        card.SetUserId(reader.GetInt32(2));
                        card.SetCardNumber(reader.GetString(3));
                        card.SetCardholderName(reader.GetString(4));
                        card.SetExpiryDate(reader.GetDateTime(5));
                        card.SetCardType(reader.GetString(6));
                        card.SetCardBrand(reader.GetString(7));
                        if (reader.GetBoolean(8)) card.Activate();
                        card.SetDailyLimit(reader.GetDecimal(9));
                        if (reader.GetBoolean(10)) card.EnableInternet();
                        card.SetPinHash(reader.GetString(11));
                        card.SetCvvHash(reader.GetString(12));
                        card.SetCreatedAt(reader.GetDateTime(13));

                        return card;
                    }
                }
            }
        }

        public void ChangePin(int cardId, string newPin)
        {
            using var conn = Db.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(
                "UPDATE cards SET pin_hash = encrypt_value(@pin) WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@pin", newPin);
            cmd.Parameters.AddWithValue("@id", cardId);
            cmd.ExecuteNonQuery();
        }

        public void BlockCard(int cardId)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE cards SET is_active = FALSE WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cardId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int cardId)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "DELETE FROM cards WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cardId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UnblockCard(int cardId)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE cards SET is_active = TRUE WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cardId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ToggleInternetPayments(int cardId, bool enabled)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE cards SET internet_enabled = @enabled WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@enabled", enabled);
                    cmd.Parameters.AddWithValue("@id", cardId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}