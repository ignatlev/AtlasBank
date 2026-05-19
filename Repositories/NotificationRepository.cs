using Bank.DB;
using Bank.Models;
using Npgsql;
using Bank.Repositories.Interfaces;

namespace Bank.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        public void Save(Notification notification)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "INSERT INTO notifications (user_id, message, type, is_read, created_at) " +
                    "VALUES (@userId, @message, @type, false, @createdAt)", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", notification.UserId);
                    cmd.Parameters.AddWithValue("@message", notification.Message);
                    cmd.Parameters.AddWithValue("@type", notification.Type);
                    cmd.Parameters.AddWithValue("@createdAt", notification.CreatedAt);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Notification> GetByUserId(int userId)
        {
            List<Notification> list = new List<Notification>();

            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "SELECT id, user_id, message, type, is_read, created_at " +
                    "FROM notifications WHERE user_id = @userId " +
                    "ORDER BY created_at DESC", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Notification notification = new Notification();
                            notification.SetId(reader.GetInt32(0));
                            notification.SetUserId(reader.GetInt32(1));
                            notification.SetMessage(reader.GetString(2));
                            notification.SetType(reader.GetString(3));
                            if (reader.GetBoolean(4)) notification.MarkAsRead();
                            notification.SetCreatedAt(reader.GetDateTime(5));
                            list.Add(notification);
                        }
                    }
                }
            }

            return list;
        }

        public void MarkAllRead(int userId)
        {
            using (NpgsqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(
                    "UPDATE notifications SET is_read = true WHERE user_id = @userId", conn))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}