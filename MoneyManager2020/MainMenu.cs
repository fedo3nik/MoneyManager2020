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
    public partial class MainMenu : Form
    {
        Menu menu;
        public void SetMenu(Menu someMenu) => menu = someMenu;

        public MainMenu()
        {
            InitializeComponent();
        }

        

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncomeForm = new AddIncomeForm();
            AddIncomeClass incomeClass = new AddIncomeClass(menu.Id, addIncomeForm);
            addIncomeForm.SetClass(incomeClass);
            addIncomeForm.Show();
        }

        private void OutlayButton_Click(object sender, EventArgs e)
        {
            AddOutlayForm addOutlayForm = new AddOutlayForm();
            addOutlayForm.Show();
        }

        private void IncomeDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void CashLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
