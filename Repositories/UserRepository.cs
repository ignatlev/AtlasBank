using Bank.DB;
using Bank.Models;
using Npgsql;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool UsernameExists(string username)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT COUNT(1) FROM users WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public bool EmailExists(string email)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT COUNT(1) FROM users WHERE email = @email", conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    return Convert.ToInt64(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public void Save(User user)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "INSERT INTO users (username, name, surname, email, password_hash, created_at) " +
                    "VALUES (@username, @name, @surname, @email, @passwordHash, @createdAt)", conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@surname", user.Surname);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@passwordHash", user.PasswordHash);
                    cmd.Parameters.AddWithValue("@createdAt", user.CreatedAt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public User? FindByUsername(string username)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT id, username, name, surname, email, password_hash, created_at " +
                    "FROM users WHERE username = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            return null;
                        }

                        User user = new User();
                        user.SetId(reader.GetInt32(0));
                        user.SetUsername(reader.GetString(1));
                        user.SetName(reader.GetString(2));
                        user.SetSurname(reader.GetString(3));
                        user.SetEmail(reader.GetString(4));
                        user.SetPasswordHash(reader.GetString(5));
                        user.SetCreatedAt(reader.GetDateTime(6));

                        return user;
                    }
                }
            }
        }
        public User? GetByEmail(string email)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT id, username, name, surname, email, password_hash, created_at " +
                    "FROM users WHERE email = @email", conn))
                {
                    cmd.Parameters.AddWithValue("@email", email.ToLower().Trim());
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;
                        User user = new User();
                        user.SetId(reader.GetInt32(0));
                        user.SetUsername(reader.GetString(1));
                        user.SetName(reader.GetString(2));
                        user.SetSurname(reader.GetString(3));
                        user.SetEmail(reader.GetString(4));
                        user.SetPasswordHash(reader.GetString(5));
                        user.SetCreatedAt(reader.GetDateTime(6));
                        return user;
                    }
                }
            }
        }

        public void UpdatePassword(int userId, string newPasswordHash)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE users SET password_hash = @passwordHash WHERE id = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@passwordHash", newPasswordHash);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}