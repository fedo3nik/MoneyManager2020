using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MoneyManager2020.FormsClasses
{
    public class AddIncomeClass
    {
        private int userId;
        private int incomeId;
        private double cash;
        private string date;
        private int incomeTypeId;
        private AddIncomeForm activeForm;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();
        private SqlDataReader reader;

        public AddIncomeClass(int userId, AddIncomeForm form)
        {
            this.userId = userId;
            this.activeForm = form;
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
            activeForm.DataGridViewIncomeTypes.DataSource = dataSet.Tables["Income_Types"];
            connect.CloseConnection();
        }

        public void Add()
        {
            try
            {
                string datePattern = @"(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).((19|20)\d\d)";

                this.incomeId = Convert.ToInt32(activeForm.IDTextBox.Text);
                this.cash = Convert.ToDouble(activeForm.CashTextBox.Text);
                this.date = activeForm.DateTextBox.Text;
                this.incomeTypeId = Convert.ToInt32(activeForm.IncomeTypeIDTextBox.Text);

                if(Regex.IsMatch(this.date, datePattern, RegexOptions.IgnoreCase))
                {           
                    try
                    {
                        connect.OpenConnection();
                        string sqlQuery = "insert into Incomes(ID, userID, cash, incomeDate, incomeTypeID)" +
                                           "values(@ID, @userID, @cash, @date, @typeId);";
                        command.Parameters.Add("@ID", SqlDbType.Int).Value = this.incomeId;
                        command.Parameters.Add("@userID", SqlDbType.Int).Value = this.userId;
                        command.Parameters.Add("@cash", SqlDbType.Money).Value = this.cash;
                        command.Parameters.Add("@date", SqlDbType.Date).Value = this.date;
                        command.Parameters.Add("@typeID", SqlDbType.Int).Value = this.incomeTypeId;

                        command.Connection = connect.GetConnection();
                        command.CommandText = sqlQuery;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Your income was succesful added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect.CloseConnection();
                    }
                    catch(SqlException e)
                    {
                        MessageBox.Show("You enter the existing ID or incorrect typeId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
