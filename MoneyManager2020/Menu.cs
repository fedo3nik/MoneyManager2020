using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MoneyManager2020
{
    public class Menu
    {
        private User user;
        private int id;
        private string email;
        private double cash;
        private MainMenu activeMenu;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();
        private string sqlQuery = "select * from Users where email = @mail and password = @pass;";
        private SqlDataReader reader;

        public Menu(MainMenu menu, User user)
        {
            this.user = user;
            this.id = user.ID;
            this.email = user.Email;
            this.cash = user.Cash;
            this.activeMenu = menu;

            activeMenu.emailLabel.Text = email;
            activeMenu.CashLabel.Text = cash.ToString();
            ShowPlanTable();
        }

        public void ShowPlanTable()
        {
            Connect connect = Connect.GetInstance();
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select Outlay_Types.descript, OutlayPlan.cash, OutlayPlan.planDate " +
                              "from OutlayPlan inner join Outlay_Types on OutlayPlan.OutlayTypeID = Outlay_Types.ID " +
                              "and OutlayPlan.userID = " + user.ID + ";";
            adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
            dataSet = new DataSet();
            connect.OpenConnection();
            adapter.Fill(dataSet, "OutlayPlan");
            activeMenu.DataGridViewPlan.DataSource = dataSet.Tables["OutlayPlan"];
            connect.CloseConnection();

        }
    }
}
