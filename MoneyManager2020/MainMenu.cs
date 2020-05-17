using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MoneyManager2020
{
    public partial class MainMenu : Form
    {
        Menu menu;
        public void SetMenu(Menu someMenu) => menu = someMenu;

        public MainMenu()
        {
            InitializeComponent();
        }

        //public void ShowTable()
        //{
        //    Connect connect = Connect.GetInstance();
        //    SqlDataAdapter adapter;
        //    DataSet dataSet;
        //    string sqlQuery = "select Outlay_Types.descript, OutlayPlan.cash, OutlayPlan.planDate " +
        //                      "from OutlayPlan inner join Outlay_Types on OutlayPlan.OutlayTypeID = Outlay_Types.ID " +
        //                      "and OutlayPlan.userID = " + user.ID + ";";
        //    adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
        //    dataSet = new DataSet();
        //    connect.OpenConnection();
        //    adapter.Fill(dataSet, "OutlayPlan");
        //    DataGridViewPlan.DataSource = dataSet.Tables["OutlayPlan"];
        //    connect.CloseConnection();
        //}

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncomeForm = new AddIncomeForm();
            addIncomeForm.Show();
        }

        private void OutlayButton_Click(object sender, EventArgs e)
        {
            AddOutlayForm addOutlayForm = new AddOutlayForm();
            addOutlayForm.Show();
        }
    }
}
