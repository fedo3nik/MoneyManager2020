using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManager2020
{
    public class User
    {
        private int id;
        private string email;
        private string password;
        private double cash;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();
        private string sqlQuery = "select * from Users where email = @mail and password = @pass;";
        private SqlDataReader reader;

        public User(SignInForm inForm)
        {
            this.email = inForm.GetEmail();
            this.password = inForm.GetPassword();
            this.id = GetID();
            this.cash = GetCash();
        }

        public int ID
        {
            get => this.id;
        }
        public string Email 
        {
            get => this.email;
        }
        public string Password 
        {
            get => this.password; 
        }
        public double Cash 
        {
            get => this.cash; 
        }

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
