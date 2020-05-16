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
using System.Text.RegularExpressions;

namespace MoneyManager2020
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            string sqlQuery = "select * from Users where email = @log and password = @pass;";

            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();
            command.Parameters.Add("@log", SqlDbType.VarChar).Value = EmailTextBox.Text;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = PasswordTextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                this.Hide();
                MessageBox.Show("Welcome to the MoneyManager2020!", "Success");
                MainMenu menu = new MainMenu();
                menu.Show();
                connect.CloseConnection();
            }

            else
            {
                if(EmailTextBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your email", "Email field is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(PasswordTextBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password", "Password field is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand();
            string sqlQuery = "select * from users where email = \'@log\' and password = \'@pass\';";
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            connect.OpenConnection();
            command.CommandText = sqlQuery;
            command.Connection = connect.GetConnection();

            if (Regex.IsMatch(EmailTextBox.Text, pattern, RegexOptions.IgnoreCase))
            {
                if(PasswordTextBox.Text.Length > 4)
                {
                    command.Parameters.Add("@log", SqlDbType.VarChar).Value = EmailTextBox.Text;
                    command.Parameters.Add("@pass", SqlDbType.VarChar).Value = PasswordTextBox.Text;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        string sqlQuery1 = "insert into Users(email, password) values(@log, @pass);";
                        SqlCommand command1 = new SqlCommand();
                        command.Connection = connect.GetConnection();
                        command.CommandText = sqlQuery1;
                        command.ExecuteNonQuery();
                        connect.CloseConnection();

                        MessageBox.Show("Your account was signed up", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MessageBox.Show("Welcome to the MoneyManager2020!", "Success");
                        MainMenu menu = new MainMenu();
                        menu.Show();
                        
                    }

                }
                else
                {
                    MessageBox.Show("Password must be longer than 5 symbols!","Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid email adress!", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
    }
}
