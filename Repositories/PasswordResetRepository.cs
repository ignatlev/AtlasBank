using Bank.DB;
using Npgsql;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class PasswordResetRepository : IPasswordResetRepository
    {
        public void Save(int userId, string code, DateTime expiresAt)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "INSERT INTO password_reset_codes (user_id, code, expires_at, used) " +
                    "VALUES (@userId, @code, @expiresAt, false)", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@expiresAt", expiresAt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool IsValid(int userId, string code)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM password_reset_codes " +
                    "WHERE user_id = @userId AND code = @code " +
                    "AND expires_at > @now AND used = false", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@now", DateTime.UtcNow);
                    return (long)cmd.ExecuteScalar()! > 0;
                }
            }
        }

        public void MarkUsed(int userId, string code)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE password_reset_codes SET used = true " +
                    "WHERE user_id = @userId AND code = @code", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}