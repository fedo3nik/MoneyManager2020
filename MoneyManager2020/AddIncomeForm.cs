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
    public partial class AddIncomeForm : Form
    {
        public AddIncomeForm()
        {
            InitializeComponent();
        }

        SqlConnection connect;
        SqlDataAdapter adapter;
        DataSet ds;

        public void ShowTable()
        {
            string sqlConnectionString = @"Data Source=DESKTOP-O1NT2UF;Initial Catalog=MoneyManager;Integrated Security=True";
            connect = new SqlConnection(sqlConnectionString);
            string sqlQuery = "select cash, planDate from OutlayPlan;";
            adapter = new SqlDataAdapter(sqlQuery, connect);
            ds = new DataSet();
            connect.Open();
            adapter.Fill(ds, "OutlayPlan");
            DataGridViewIncomeTypes.DataSource = ds.Tables["OutlayPlan"];
            connect.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddIncomeForm_Load(object sender, EventArgs e)
        {
            ShowTable();
        }
    }
}
