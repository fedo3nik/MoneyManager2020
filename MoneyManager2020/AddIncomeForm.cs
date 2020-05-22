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
using MoneyManager2020.FormsClasses;

namespace MoneyManager2020
{
    public partial class AddIncomeForm : Form
    {
        AddIncomeClass addIncome;
        MainMenu menu;
        public void SetClass(AddIncomeClass income) => addIncome = income;
        public void SetMenu(MainMenu mainMenu) => menu = mainMenu;

        public AddIncomeForm()
        {
            InitializeComponent();
        }

        private void AddIncomeForm_Load(object sender, EventArgs e)
        {
            addIncome.ShowIncomeTypes();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addIncome.Add();
        }

    }
}
