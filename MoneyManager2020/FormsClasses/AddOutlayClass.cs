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
    public class AddOutlayClass
    {
        private int userId;
        private int outlayId;
        private double cash;
        private string date;
        private int outlayTypeId;
        private AddOutlayForm activeForm;
        private Menu activeMenu;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();

        public AddOutlayClass(int userId, AddOutlayForm form, Menu menu)
        {
            this.userId = userId;
            this.activeForm = form;
            this.activeMenu = menu;
            this.outlayId = SetIdTextBox() + 1;
            this.activeForm.IDTextBox.Text = outlayId.ToString();
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
            activeForm.DataGridViewOutlayTypes.DataSource = dataSet.Tables["Outlay_Types"];
            connect.CloseConnection();
        }

        public int SetIdTextBox()
        {
            int tempId;
            SqlDataReader reader;
            string sqlQuery = "select top 1 ID from Outlays order by ID desc;";
            connect.OpenConnection();
            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();

            reader = command.ExecuteReader();
            while (reader.Read())
            {
                tempId = Convert.ToInt32(reader["ID"]);
                reader.Close();
                connect.CloseConnection();
                return tempId;
            }
            reader.Close();
            return 0;
        }


        public void Add()
        {
            try
            {
                string datePattern = @"(0?[1-9]|[12][0-9]|3[01]).(0?[1-9]|1[012]).((19|20)\d\d)";

                this.outlayId = Convert.ToInt32(activeForm.IDTextBox.Text);
                this.cash = Convert.ToDouble(activeForm.CashTextBox.Text);
                this.date = activeForm.DateTextBox.Text;
                this.outlayTypeId = Convert.ToInt32(activeForm.IncomeTypeIDTextBox.Text);

                if (Regex.IsMatch(this.date, datePattern, RegexOptions.IgnoreCase))
                {
                    try
                    {
                        connect.OpenConnection();
                        string sqlQuery = "insert into Outlays(ID, userID, cash, outlayDate, outlayTypeID)" +
                                           "values(@ID, @userID, @cash, @date, @typeId);\n" +
                                           "update Users set Users.cash = Users.cash - @cash where ID = @userID;";
                        command.Parameters.Add("@ID", SqlDbType.Int).Value = this.outlayId;
                        command.Parameters.Add("@userID", SqlDbType.Int).Value = this.userId;
                        command.Parameters.Add("@cash", SqlDbType.Money).Value = this.cash;
                        command.Parameters.Add("@date", SqlDbType.Date).Value = this.date;
                        command.Parameters.Add("@typeID", SqlDbType.Int).Value = this.outlayTypeId;

                        command.Connection = connect.GetConnection();
                        command.CommandText = sqlQuery;
                        command.ExecuteNonQuery();
                        MessageBox.Show("Your outlay was succesful added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect.CloseConnection();
                        activeMenu.Cash = activeMenu.GetCash();
                        activeMenu.ShowCash();
                        activeMenu.LastOutlay = activeMenu.GetLastOutlay();
                        activeMenu.LastOutlayDate = activeMenu.GetLastOutlayDate();
                        activeMenu.ShowLastOutlay();
                        activeMenu.ShowLastOutlayDate();

                        activeForm.Close();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("You enter the existing ID or incorrect typeId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        activeForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect date format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    activeForm.Close();
                }

            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                activeForm.Close();
            }
        }

    }
}
