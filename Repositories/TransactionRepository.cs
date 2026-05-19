using Bank.DB;
using Bank.Models;
using Npgsql;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        public List<Transaction> GetByUserId(int userId)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT t.id, t.account_id, a.account_name, a.account_number, " +
                    "t.to_account_id, t.description, t.amount, t.type, t.date, " +
                     "b.account_number AS to_account_number " +
                    "FROM transactions t " +
                    "JOIN bank_accounts a ON t.account_id = a.id " +
                    "LEFT JOIN bank_accounts b ON t.to_account_id = b.id " +
                       "WHERE a.user_id = @userId " + "ORDER BY t.date DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);


                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction();
                            transaction.SetId(reader.GetInt32(0));
                            transaction.SetAccountId(reader.GetInt32(1));
                            transaction.SetAccountName(reader.GetString(2));
                            transaction.SetAccountNumber(reader.GetString(3));
                            if (reader.IsDBNull(4))
                            {
                                transaction.SetToAccountId(null);
                            }
                            else
                            {
                                transaction.SetToAccountId(reader.GetInt32(4));
                            }

                            transaction.SetDescription(reader.GetString(5));
                            transaction.SetAmount(reader.GetDecimal(6));
                            transaction.SetType((TransactionType)Enum.Parse(typeof(TransactionType), reader.GetString(7)));
                            transaction.SetCreatedAt(reader.GetDateTime(8));
                            transaction.SetToAccountNumber(reader.IsDBNull(9) ? string.Empty : reader.GetString(9));
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public List<Transaction> GetByUserId(int userId, DateTime startDate, DateTime endDate)
        {
            List<Transaction> transactions = new List<Transaction>();

            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT t.id, t.transfer_id, t.account_id, a.account_name, a.account_number, " +
                    "t.to_account_id, t.description, t.amount, t.type, t.date, " +
                    "b.account_number AS to_account_number " +
                    "FROM transactions t " +
                    "JOIN bank_accounts a ON t.account_id = a.id " +
                    "LEFT JOIN bank_accounts b ON t.to_account_id = b.id " +
                    "WHERE a.user_id = @userId " +
                    "AND t.date >= @startDate " +
                    "AND t.date < @endDate " +
                    "ORDER BY t.date DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate.AddDays(1));

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transaction transaction = new Transaction();
                            transaction.SetId(reader.GetInt32(0));
                            transaction.SetAccountId(reader.GetInt32(1));
                            transaction.SetAccountName(reader.GetString(2));
                            transaction.SetAccountNumber(reader.GetString(3));
                            if (reader.IsDBNull(4))
                            {
                                transaction.SetToAccountId(null);
                            }
                            else
                            {
                                transaction.SetToAccountId(reader.GetInt32(4));
                            }

                            transaction.SetDescription(reader.GetString(5));
                            transaction.SetAmount(reader.GetDecimal(6));
                            transaction.SetType((TransactionType)Enum.Parse(typeof(TransactionType), reader.GetString(7)));
                            transaction.SetCreatedAt(reader.GetDateTime(8));
                            transaction.SetToAccountNumber(reader.IsDBNull(9) ? string.Empty : reader.GetString(9));
                            transactions.Add(transaction);
                        }
                    }
                }
            }

            return transactions;
        }

        public Transaction SaveTransfer(Transaction transaction, BankAccount fromAccount, BankAccount? toAccount, decimal amount, string beneficiaryAccountNumber)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlTransaction dbTx = conn.BeginTransaction())
                {
                    try
                    {
                        using (NpgsqlCommand cmd = new NpgsqlCommand(
                            "UPDATE bank_accounts SET balance = balance - @amount WHERE id = @id", conn, dbTx))
                        {
                            cmd.Parameters.AddWithValue("@amount", amount);
                            cmd.Parameters.AddWithValue("@id", fromAccount.Id);
                            cmd.ExecuteNonQuery();
                        }

                        if (toAccount != null)
                        {
                            using (NpgsqlCommand cmd = new NpgsqlCommand(
                                "UPDATE bank_accounts SET balance = balance + @amount WHERE id = @id", conn, dbTx))
                            {
                                cmd.Parameters.AddWithValue("@amount", amount);
                                cmd.Parameters.AddWithValue("@id", toAccount.Id);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (NpgsqlCommand cmd = new NpgsqlCommand(
                            "INSERT INTO transactions " +
                            "  (account_id, to_account_id, description, amount, type, date, to_account_number) " +
                            "VALUES (@accountId, @toAccountId, @description, @amount, @type, @date, @toAccountNumber)",
                            conn, dbTx))
                        {
                            cmd.Parameters.AddWithValue("@accountId", transaction.AccountId);
                            cmd.Parameters.AddWithValue("@toAccountId", transaction.ToAccountId.HasValue
                                ? (object)transaction.ToAccountId.Value
                                : DBNull.Value);
                            cmd.Parameters.AddWithValue("@description", transaction.Description);
                            cmd.Parameters.AddWithValue("@amount", transaction.Amount);
                            cmd.Parameters.AddWithValue("@type", TransactionType.Expense.ToString());
                            cmd.Parameters.AddWithValue("@date", transaction.CreatedAt);
                            cmd.Parameters.AddWithValue("@toAccountNumber", transaction.ToAccountNumber);
                            cmd.ExecuteNonQuery();
                        }

                        if (toAccount != null)
                        {
                            using (NpgsqlCommand cmd = new NpgsqlCommand(
                                "INSERT INTO transactions " +
                                "  (account_id, to_account_id, description, amount, type, date) " +
                                "VALUES (@accountId, @toAccountId, @description, @amount, @type, @date)",
                                conn, dbTx))
                            {
                                cmd.Parameters.AddWithValue("@accountId", toAccount.Id);
                                cmd.Parameters.AddWithValue("@toAccountId", (object)transaction.AccountId);
                                cmd.Parameters.AddWithValue("@description", transaction.Description);
                                cmd.Parameters.AddWithValue("@amount", transaction.Amount);
                                cmd.Parameters.AddWithValue("@type", TransactionType.Income.ToString());
                                cmd.Parameters.AddWithValue("@date", transaction.CreatedAt);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        dbTx.Commit();
                        return transaction;
                    }
                    catch
                    {
                        dbTx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}