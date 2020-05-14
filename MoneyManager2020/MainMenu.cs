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
        public MainMenu()
        {
            InitializeComponent();
        }

        SqlConnection connect;
        SqlDataAdapter adapter;
        DataSet ds;
        //SqlCommand _command;
        //SqlDataReader _reader;
        
        public void ShowTable()
        {
            string sqlConnectionString = @"Data Source=DESKTOP-O1NT2UF;Initial Catalog=MoneyManager;Integrated Security=True";
            connect = new SqlConnection(sqlConnectionString);
            string sqlQuery = "select cash, planDate from OutlayPlan;";
            adapter = new SqlDataAdapter(sqlQuery, connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "OutlayPlan");
            DataGridViewPlan.DataSource = ds.Tables["OutlayPlan"];
            connect.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ShowTable();
        }
    }
}
