using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DataBase
{
    class DataBase
    {
        private static string connectionSrting = "";// "Server=localhost;Port=5432;User ID = postgres; Password=Vitas2001;Database=library;";
        private NpgsqlConnection connection = new NpgsqlConnection(connectionSrting);

        public static string ConnectionString
        {
            set
            {
                connectionSrting = value;
            }
        }
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public NpgsqlConnection GetConnection()
        {
            return connection;
        }
    }
}
