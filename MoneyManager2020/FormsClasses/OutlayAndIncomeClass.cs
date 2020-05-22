using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MoneyManager2020.FormsClasses
{
    public class OutlayAndIncomeClass
    {
        private int incomeId;
        private string incomeDescription;
        private int outlayId;
        private string outlayDescription;
        private Menu activeMenu;
        private OutlayAndIncomeTypesForm activeForm;
        private Connect connect = Connect.GetInstance();
        private SqlCommand command = new SqlCommand();

        public OutlayAndIncomeClass(OutlayAndIncomeTypesForm form, Menu menu)
        {
            this.activeMenu = menu;
            this.activeForm = form;
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
            activeForm.OutlayTypesDataGridView.DataSource = dataSet.Tables["Outlay_Types"];
            connect.CloseConnection();
        }

        public void ShowIncomesTypes()
        {
            SqlDataAdapter adapter;
            DataSet dataSet;
            string sqlQuery = "select * from Income_Types;";
            adapter = new SqlDataAdapter(sqlQuery, connect.GetConnection());
            dataSet = new DataSet();
            connect.OpenConnection();
            adapter.Fill(dataSet, "Income_Types");
            activeForm.IncomeTypesDataGridView.DataSource = dataSet.Tables["Income_Types"];
            connect.CloseConnection();
        }

        public void AddIncomeType()
        {
            try
            {
                this.incomeId = Convert.ToInt32(activeForm.IncomeIdTextBox.Text);
                this.incomeDescription = activeForm.IncomeDescription.Text;

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
                    ShowIncomesTypes();
                }
                catch(SqlException e)
                {
                    MessageBox.Show("You enter the existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    activeForm.Close();
                }
            }
            catch(FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void AddOutlayType()
        {
            try
            {
                this.outlayId = Convert.ToInt32(activeForm.OutlayIdTextBox.Text);
                this.outlayDescription = activeForm.OutlayDescriptionTextBox.Text;

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
                    MessageBox.Show("You enter the existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    activeForm.Close();
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
                this.incomeId = Convert.ToInt32(activeForm.IncomeIdTextBox.Text);

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
                    ShowIncomesTypes();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    activeForm.Close();
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
                this.outlayId = Convert.ToInt32(activeForm.IncomeIdTextBox.Text);

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
                    ShowIncomesTypes();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("You enter the not existing ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    activeForm.Close();
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Some field are empty or has incorrect format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
