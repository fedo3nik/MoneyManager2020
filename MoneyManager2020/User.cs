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
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();
        private string sqlQuery = "select * from Users where email = @mail and password = @pass;";
        private SqlDataReader reader;

        public User(SignInForm inForm, MainMenu menu)
        {
            this.email = inForm.GetEmail();
            this.password = inForm.GetPassword();
            this.ID = GetID();
            this.cash = GetCash();

            menu.emailLabel.Text = this.email;
            menu.CashLabel.Text = this.cash.ToString();
        }

        public string GetEmail() => this.email;
        public string GetPassword() => this.password;

        public int GetID()
        {
            int tempID;
            connect.OpenConnection();
            command.Connection = connect.GetConnection();
            command.Parameters.Add("@mail", System.Data.SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pass", System.Data.SqlDbType.VarChar).Value = password;
            command.CommandText = sqlQuery;

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tempID = Convert.ToInt32(reader["ID"]);
                connect.CloseConnection();
                return tempID;
            }
            return 0;
        }

        public double GetCash()
        {
            double tempCash;
            connect.OpenConnection();
            command.Connection = connect.GetConnection();
            command.CommandText = sqlQuery;

            reader = command.ExecuteReader();
            while(reader.Read())
            {
                tempCash = Convert.ToDouble(reader["cash"]);
                connect.CloseConnection();
                return tempCash;
            }
            return 0;
        }
    }
}
