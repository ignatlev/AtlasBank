using Npgsql;
using System.Configuration;

namespace Bank.DB
{
    public static class Db
    {
        public static NpgsqlConnection GetConnection()
        {
            string conn = ConfigurationManager.AppSettings["db-connection"]!;
            return new NpgsqlConnection(conn);
        }
    }
}