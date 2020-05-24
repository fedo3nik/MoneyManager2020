using MoneyManager2020.MenuClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManager2020
{
    public partial class AdminMenuForm : Form
    {
        AdminMenu menu;
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        public void SetMenu(AdminMenu someMenu) => menu = someMenu;

        private void AdminMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {
            menu.ShowUsersList();
            menu.ShowIncomeTypes();
            menu.ShowOutlayTypes();
        }

        private void AddIncomeButton_Click(object sender, EventArgs e)
        {
            menu.AddIncomeType();
        }

        private void AddOutlayButton_Click(object sender, EventArgs e)
        {
            menu.AddOutlayType();
        }

        private void DeleteIncomeButton_Click(object sender, EventArgs e)
        {
            menu.DeleteIncomeType();
        }

        private void DeleteOutlayButton_Click(object sender, EventArgs e)
        {
            menu.DeleteOutlayType();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            menu.DeleteUser();
        }
    }
}
