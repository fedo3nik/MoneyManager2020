using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Schema;

namespace MoneyManager2020
{
    public class Menu
    {
        private OrdinaryUser user;
        private int id;
        private string email;
        private double cash;
        private double lastIncome;
        private string lastIncomeDate;
        private double lastOutlay;
        private string lastOutlayDate;
        private MainMenu activeMenu;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;

        public Menu(MainMenu menu, OrdinaryUser user)
        {
            this.user = user;
            this.id = user.ID;
            this.email = user.Email;
            this.cash = GetCash();
            this.activeMenu = menu;
            this.lastIncome = GetLastIncome();
            this.lastIncomeDate = GetLastIncomeDate();
            this.lastOutlay = GetLastOutlay();
            this.lastOutlayDate = GetLastOutlayDate();

            ShowCash();
            activeMenu.emailLabel.Text = email;
            ShowPlanTable();
            ShowLastIncome();
            ShowLastIncomeDate();
            ShowLastOutlay();
            ShowLastOutlayDate();
        }

        public MainMenu ActiveMenu
        {
            get => this.activeMenu;
        }
        public int Id
        {
            get => this.id;
        }
        public double Cash
        {
            get => this.cash;
            set => this.cash = value;
        }
        public double LastIncome
        {
            get => this.lastIncome;
            set => this.lastIncome = value;
        }
        public double LastOutlay
        {
            get => this.lastOutlay;
            set => this.lastOutlay = value;
        }
        public string LastIncomeDate
        {
            get => this.lastIncomeDate;
            set => this.lastIncomeDate = value;
        }
        public string LastOutlayDate
        {
            get => this.lastOutlayDate;
            set => this.lastOutlayDate = value;
        }

        

        public void ShowPlanTable()
        {
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

        public double GetCash()
        {
            double tempCash;
            string sqlQuery = "select cash from Users where ID = " + this.id + ";";
            connect.OpenConnection();
            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();

            reader = command.ExecuteReader();
            while(reader.Read())
            {
                tempCash = Convert.ToDouble(reader["cash"]);
                reader.Close();
                connect.CloseConnection();
                return tempCash;
            }
            reader.Close();
            return 0;
        }

        public void ShowCash() => activeMenu.CashLabel.Text = this.cash.ToString() + " $";

        public double GetLastIncome()
        {
            double tempIncome;
            string sqlQuery = "select top 1 cash from Incomes where userID =" + this.id + " order by ID desc;";
            connect.OpenConnection();
            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();

            reader = command.ExecuteReader();
            while(reader.Read())
            {
                tempIncome = Convert.ToDouble(reader["cash"]);
                reader.Close();
                connect.CloseConnection();
                return tempIncome;
            }
            reader.Close();
            return 0;
        }

        public void ShowLastIncome() => activeMenu.LastIncomeLabel.Text = this.lastIncome.ToString() + " $";
        public void ShowLastOutlay() => activeMenu.LastOutlayLabel.Text = this.lastOutlay.ToString() + " $";
        public void ShowLastIncomeDate() => activeMenu.IncomeDateLabel.Text = this.lastIncomeDate;
        public void ShowLastOutlayDate() => activeMenu.OutlayDateLabel.Text = this.lastOutlayDate;

        public string GetLastIncomeDate()
        {
            string tempIncomeDate;
            string sqlQuery = "select top 1 incomeDate from Incomes where userID =" + this.id + " order by ID desc;";
            connect.OpenConnection();
            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tempIncomeDate = Convert.ToString(reader["incomeDate"]);
                reader.Close();
                connect.CloseConnection();
                return tempIncomeDate;
            }
            reader.Close();
            return "dd";
        }

        public double GetLastOutlay()
        {
            double tempOutlay;
            string sqlQuery = "select top 1 cash from Outlays where userID =" + this.id + " order by ID desc;";
            connect.OpenConnection();
            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tempOutlay = Convert.ToDouble(reader["cash"]);
                reader.Close();
                connect.CloseConnection();
                return tempOutlay;
            }
            reader.Close();
            return 0;
        }

        public string GetLastOutlayDate()
        {
            string tempOutlayDate;
            string sqlQuery = "select top 1 outlayDate from Outlays where userID =" + this.id + " order by ID desc;";
            connect.OpenConnection();
            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tempOutlayDate = Convert.ToString(reader["outlayDate"]);
                reader.Close();
                connect.CloseConnection();
                return tempOutlayDate;
            }
            reader.Close();
            return "dd";
        }

    }
}
