using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MoneyManager2020.MenuClasses
{
    public class AdminMenu
    {
        private int userId;
        private int incomeId;
        private int outlayId;
        private string incomeDescription;
        private string outlayDescription;
        private Admin admin;
        private int id;
        private string email;
        private AdminMenuForm activeMenu;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;

        public AdminMenu(AdminMenuForm menuForm, Admin admin)
        {
            this.admin = admin;
            this.id = admin.ID;
            this.email = admin.Email;
            this.activeMenu = menuForm;
        }

        public void ShowUsersList()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select id, email, cash from Users;";
            adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
            dataSet = new DataSet();
            connect.OpenConnection();
            adapter.Fill(dataSet, "Users");
            activeMenu.UsersListDataGridView.DataSource = dataSet.Tables["Users"];
            connect.CloseConnection();
        }

        public void ShowIncomeTypes()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select * from Income_Types;";
            adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
            dataSet = new DataSet();
            connect.OpenConnection();
            adapter.Fill(dataSet, "Income_Types");
            activeMenu.IncomeDataGridView.DataSource = dataSet.Tables["Income_Types"];
            connect.CloseConnection();
        }        
        public void ShowOutlayTypes()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select * from Outlay_Types;";
            adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
            dataSet = new DataSet();
            connect.OpenConnection();
            adapter.Fill(dataSet, "Outlay_Types");
            activeMenu.OutlayDataGridView.DataSource = dataSet.Tables["Outlay_Types"];
            connect.CloseConnection();
        }

        public void AddIncomeType()
        {
            try
            {
                this.incomeId = Convert.ToInt32(activeMenu.IdTextBox.Text);
                this.incomeDescription = activeMenu.DescriptTextBox.Text;

                try
                {
                    connect.OpenConnection();
                    string sqlQuery = "insert into Income_Types(ID, descript) values (@ID, @descript);";

                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.incomeId;
                    command.Parameters.Add("@descript", SqlDbType.VarChar).Value = this.incomeDescription;
                    command.Connection = connect.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("New income type was successfuly added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.CloseConnection();
                    ShowIncomeTypes();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void AddOutlayType()
        {
            try
            {
                this.outlayId = Convert.ToInt32(activeMenu.IdTextBox.Text);
                this.outlayDescription = activeMenu.DescriptTextBox.Text;

                try
                {
                    connect.OpenConnection();
                    string sqlQuery = "insert into Outlay_Types(ID, descript) values (@ID, @descript);";

                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.outlayId;
                    command.Parameters.Add("@descript", SqlDbType.VarChar).Value = this.outlayDescription;
                    command.Connection = connect.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("New outlay type was successfuly added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.CloseConnection();
                    ShowOutlayTypes();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void DeleteIncomeType()
        {
            try
            {
                this.incomeId = Convert.ToInt32(activeMenu.IdTextBox.Text);

                try
                {
                    connect.OpenConnection();
                    string sqlQuery = "delete from Income_Types where ID = @ID;";

                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.incomeId;
                    command.Connection = connect.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Income type was successfuly deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.CloseConnection();
                    ShowIncomeTypes();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteOutlayType()
        {
            try
            {
                this.outlayId = Convert.ToInt32(activeMenu.IdTextBox.Text);

                try
                {
                    connect.OpenConnection();
                    string sqlQuery = "delete from Outlay_Types where ID = @ID;";

                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.outlayId;
                    command.Connection = connect.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Outlay type was successfuly deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.CloseConnection();
                    ShowIncomeTypes();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteUser()
        {
            try 
            {
                this.userId = Convert.ToInt32(this.activeMenu.UserIdTextBox.Text);

                try
                {
                    connect.OpenConnection();
                    string sqlQuery = "delete from Incomes where userID = @userID;\n" +
                                      "delete from Outlays where userID = @userID;\n" +
                                      "delete from OutlayPlan where userID = @userID;\n" +
                                      "delete from Users where ID = @userID";

                    command.Parameters.Add("@userID", SqlDbType.Int).Value = this.userId;
                    command.Connection = connect.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    connect.CloseConnection();
                    MessageBox.Show("User was successfuly deleted from the DB", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowUsersList();
                }
                catch(SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
