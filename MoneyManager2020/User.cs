using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManager2020
{
    class User
    {
        private int ID;
        private string email;
        private string password;
        private double cash;
        private Connect connect;
        private SqlCommand command = new SqlCommand();
        private string sqlQuery = "select Users.ID from Users where email = @mail and password = @pass;";
        private SqlDataReader reader;

        public User(SignInForm inForm, MainMenu menu)
        {
            this.email = inForm.GetEmail();
            this.password = inForm.GetPassword();
            this.ID = GetID();
            this.cash = GetCash();
        }

        public string GetEmail() => this.email;
        public string GetPassword() => this.password;

        public int GetID()
        {
            command.Connection = connect.GetConnection();
            command.Parameters.Add("@mail", System.Data.SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pass", System.Data.SqlDbType.VarChar).Value = password;
            command.CommandText = sqlQuery;

            reader = command.ExecuteReader();
            return Convert.ToInt32(reader["ID"]);
        }

        public double GetCash()
        {
            command.Connection = connect.GetConnection();
            command.Parameters.Add("@mail", System.Data.SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pass", System.Data.SqlDbType.VarChar).Value = password;
            command.CommandText = sqlQuery;

            reader = command.ExecuteReader();
            return Convert.ToDouble(reader["cash"]);
        }
    }
}
