using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MoneyManager2020
{
    public class Admin 
    {
        private int id;
        private string email;
        private string password;
        private Connect connect;
        private SqlCommand command = new SqlCommand();
        private string sqlQuery = "select * from Admins where email = @mail and password = @pass;";
        private SqlDataReader reader;

        public Admin(SignInForm inForm)
        {
            this.connect = Connect.GetInstance();
            this.email = inForm.GetEmail();
            this.password = inForm.GetPassword();
            this.id = GetID();
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
                reader.Close();
                connect.CloseConnection();
                return tempID;
            }
            return 0;
        }

    }
}
