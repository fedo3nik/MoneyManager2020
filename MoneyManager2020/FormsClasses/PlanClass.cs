using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;

namespace MoneyManager2020.FormsClasses
{
    public class PlanClass
    {
        private int id;
        private int userId;
        private double cash;
        private int typeId;
        private string date;
        private Menu activeMenu;
        private PlanForm activeForm;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();

        public Menu ActiveMenu
        {
            get => this.activeMenu;
        }

        public PlanClass(int userId, Menu menu, PlanForm form)
        {
            this.userId = userId;
            this.activeMenu = menu;
            this.activeForm = form;
        }

        public void ShowTypes()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select * from Outlay_Types";
            adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
            dataSet = new DataSet();
            connect.OpenConnection();
            adapter.Fill(dataSet, "Outlay_Types");
            activeForm.DataGridViewTypes.DataSource = dataSet.Tables["Outlay_Types"];
            connect.CloseConnection();

        }

        public void ShowPlan()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select  OutlayPlan.ID, Outlay_Types.descript, OutlayPlan.cash, OutlayPlan.planDate " +
                              "from OutlayPlan inner join Outlay_Types on OutlayPlan.OutlayTypeID = Outlay_Types.ID " +
                              "and OutlayPlan.userID = " + this.userId + ";";
            adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
            dataSet = new DataSet();
            connect.OpenConnection();
            adapter.Fill(dataSet, "OutlayPlan");
            activeForm.DataGridViewPlan.DataSource = dataSet.Tables["OutlayPlan"];
            connect.CloseConnection();
        }

        public void Add()
        {
            try
            {
                string datePattern = @"(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).((19|20)\d\d)";

                this.id = Convert.ToInt32(activeForm.IDTextBox.Text);
                this.cash = Convert.ToDouble(activeForm.CashTextBox.Text);
                this.date = activeForm.DateTextBox.Text;
                this.typeId = Convert.ToInt32(activeForm.OutlayTypeIDTextBox.Text);
                if (Regex.IsMatch(this.date, datePattern, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        connect.OpenConnection();
                        string sqlQuery = "insert into OutlayPlan(ID, userID, cash, planDate, outlayTypeID)" +
                                          "values(@ID, @userID, @cash, @date, @typeID);";

                        command.Parameters.Add("@ID", SqlDbType.Int).Value = this.id;
                        command.Parameters.Add("@userID", SqlDbType.Int).Value = this.userId;
                        command.Parameters.Add("@cash", SqlDbType.Money).Value = this.cash;
                        command.Parameters.Add("@date", SqlDbType.Date).Value = this.date;
                        command.Parameters.Add("@typeID", SqlDbType.Int).Value = this.typeId;
                        command.Connection = connect.GetConnection();
                        command.CommandText = sqlQuery;
                        command.ExecuteNonQuery();
                        MessageBox.Show("New outlay was successfuly added into plan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        command.Parameters.Clear();
                        connect.CloseConnection();
                        ShowPlan();
                        activeMenu.ShowPlanTable();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("You enter the existing ID or incorrect type id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        command.Parameters.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Parameters.Clear();
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Parameters.Clear();
            }
        }

        public void Delete()
        {
            try
            {
                this.id = Convert.ToInt32(activeForm.IDTextBox.Text);
                try
                {
                    connect.OpenConnection();
                    string sqlQuery = "delete from OutlayPlan where ID = @ID;";

                    command.Parameters.Add("@ID", SqlDbType.Int).Value = this.id;
                    command.Connection = connect.GetConnection();
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Outlay was successfuly deleted into plan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command.Parameters.Clear();
                    connect.CloseConnection();
                    ShowPlan();
                    activeMenu.ShowPlanTable();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the existing ID or incorrect type id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    command.Parameters.Clear();
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Parameters.Clear();
            }
        }

        public void Update()
        {
            try
            {
                string datePattern = @"(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).((19|20)\d\d)";

                this.id = Convert.ToInt32(activeForm.IDTextBox.Text);
                this.cash = Convert.ToDouble(activeForm.CashTextBox.Text);
                this.date = activeForm.DateTextBox.Text;
                this.typeId = Convert.ToInt32(activeForm.OutlayTypeIDTextBox.Text);
                if (Regex.IsMatch(this.date, datePattern, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        connect.OpenConnection();
                        string sqlQuery = "update OutlayPlan set cash = @cash, planDate = @date, OutlayTypeID = @typeID where ID = @ID";

                        command.Parameters.Add("@ID", SqlDbType.Int).Value = this.id;
                        command.Parameters.Add("@cash", SqlDbType.Money).Value = this.cash;
                        command.Parameters.Add("@date", SqlDbType.Date).Value = this.date;
                        command.Parameters.Add("@typeID", SqlDbType.Int).Value = this.typeId;
                        command.Connection = connect.GetConnection();
                        command.CommandText = sqlQuery;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Outay was successfuly updated in plan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        command.Parameters.Clear();
                        connect.CloseConnection();
                        ShowPlan();
                        activeMenu.ShowPlanTable();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("You enter the existing ID or incorrect type id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        command.Parameters.Clear();
                    }
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                command.Parameters.Clear();
            }
        }
    }
}
