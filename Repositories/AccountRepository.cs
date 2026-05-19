using Bank.DB;
using Bank.Models;
using Npgsql;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public List<BankAccount> GetByUserId(int userId)
        {
            List<BankAccount> accounts = new List<BankAccount>();

            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT id, user_id, account_number, account_name, balance, created_at " +
                    "FROM bank_accounts WHERE user_id = @userId AND is_closed = FALSE", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BankAccount account = new BankAccount();
                            account.SetId(reader.GetInt32(0));
                            account.SetUserId(reader.GetInt32(1));
                            account.SetAccountNumber(reader.GetString(2));
                            account.SetAccountName(reader.GetString(3));
                            account.SetInitialBalance(reader.GetDecimal(4));
                            account.SetCreatedAt(reader.GetDateTime(5));
                            accounts.Add(account);
                        }
                    }
                }
            }

            return accounts;
        }

        public BankAccount? GetByAccountNumber(string accountNumber)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT id, user_id, account_number, account_name, balance, created_at " +
                    "FROM bank_accounts WHERE UPPER(account_number) = @accountNumber AND is_closed = FALSE", conn))
                {
                    cmd.Parameters.AddWithValue("@accountNumber", accountNumber.ToUpper());

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            BankAccount account = new BankAccount();
                            account.SetId(reader.GetInt32(0));
                            account.SetUserId(reader.GetInt32(1));
                            account.SetAccountNumber(reader.GetString(2));
                            account.SetAccountName(reader.GetString(3));
                            account.SetInitialBalance(reader.GetDecimal(4));
                            account.SetCreatedAt(reader.GetDateTime(5));
                            return account;
                        }

                        return null;
                    }
                }
            }
        }

        public void Save(BankAccount account)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "INSERT INTO bank_accounts (user_id, account_number, account_name, balance, created_at) " +
                    "VALUES (@userId, generate_account_number(), @accountName, @balance, @createdAt)", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", account.UserId);
                    cmd.Parameters.AddWithValue("@accountName", account.AccountName);
                    cmd.Parameters.AddWithValue("@balance", account.Balance);
                    cmd.Parameters.AddWithValue("@createdAt", account.CreatedAt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool AccountNumberExists(string accountNumber)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT COUNT(1) FROM bank_accounts WHERE account_number = @accountNumber", conn))
                {
                    cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                    return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Delete(int accountId)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE bank_accounts SET is_closed = TRUE WHERE id = @accountId", conn))
                {
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Rename(int accountId, string newName)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE bank_accounts SET account_name = @accountName WHERE id = @accountId", conn))
                {
                    cmd.Parameters.AddWithValue("@accountName", newName);
                    cmd.Parameters.AddWithValue("@accountId", accountId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}