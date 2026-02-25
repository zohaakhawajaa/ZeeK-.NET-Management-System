using System;
using MySql.Data.MySqlClient;

namespace ZeeK
{
    public static class DB
    {
        private static readonly string connectionString =
            "Server=localhost;Database=zeekdb;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}