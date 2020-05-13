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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        SqlConnection _connect;
        SqlCommand _command;
        SqlDataReader _reader;

        void ConnectToSql()
        {
            _connect = new SqlConnection(@"Data Source=DESKTOP-O1NT2UF;Initial Catalog=MoneyManager;Integrated Security=True");
            _connect.Open();
            _connect.Close();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            ConnectToSql();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string _email = EmailTextBox.Text;
            string _password = PasswordTextBox.Text;
            bool flag = false;

            _connect.Open();
            string sqlQuery = "select * from Users";
            _command = new SqlCommand(sqlQuery, _connect);
            _reader = _command.ExecuteReader();
            
            if(!_reader.HasRows)
            {
                MessageBox.Show("In the data base has no users!\nPlease sign up");
            }
            else
            {
                while(_reader.Read())
                {
                    object email = _reader["email"];
                    object password = _reader["password"];

                    if(_email == email.ToString() && _password == password.ToString())
                    {
                        flag = true;                    }
                }

                if(flag)
                {
                    MessageBox.Show("Welcome to the MoneyManager2020!");
                    MainMenu newMenu = new MainMenu();
                    newMenu.Show();
                    _reader.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect email or password!");
                    _reader.Close();
                }
            }

            _connect.Close();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string _email = EmailTextBox.Text;
            string _password = PasswordTextBox.Text;
            bool emailFlag = false;
            bool passFlag = false;
            int symCounter = 0;
         
            for(int i = 0; i < _email.Length; i++)
            {
                if(_email[0] == '@' || _email[0] == '.')
                {
                    emailFlag = false;
                    break;
                }

                if (symCounter == 0)
                {
                    if (_email[i] == '@')
                    {
                        if (_email[i + 1] != '.')
                        {
                            ++symCounter;
                        }
                    }
                }
                else
                {
                    if(_email[i] == '@')
                    {
                        emailFlag = false;
                        break;
                    }
                    else
                    {
                        emailFlag = true;
                        break;
                    }
                }
            }

            if(_password.Length < 5)
            {
                passFlag = false;
            }
            else
            {
                passFlag = true;
            }

            if (emailFlag)
            {
                if (passFlag)
                {
                    _command = new SqlCommand();
                    _connect.Open();
                    _command.Connection = _connect;
                    _command.CommandText = "insert into Users(email, password) values(\'" + _email + "\', \'" + _password + "\');"; 
                    _command.ExecuteNonQuery();
                    _connect.Close();

                    MessageBox.Show("Congratulations!\nYou was succesfully signed up!!!");
                }
                else
                {
                    MessageBox.Show("Invalid password!\nPassword minimum length must be 5 symbols!");
                }
            }
            else
            {
                MessageBox.Show("Invalid email!");
            }
        }
    }
}
