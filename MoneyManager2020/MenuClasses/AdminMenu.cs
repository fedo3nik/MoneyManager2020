using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MoneyManager2020.MenuClasses
{
    public class AdminMenu
    {
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
            string sqlQuery = "select * from Users;";
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
    }
}
