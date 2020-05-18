using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManager2020
{
    public class Connect
    {
        private static string connectionString = @"Data Source=DESKTOP-O1NT2UF;Initial Catalog = MoneyManager; Integrated Security = True";
        private static readonly Connect instance = new Connect();
        private SqlConnection connection;

        private Connect()
        {
            connection = new SqlConnection(connectionString);
        }

        public static Connect GetInstance() => instance;

        public SqlConnection GetConnection() => connection;

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


    }
}
