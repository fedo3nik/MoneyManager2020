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

        public Menu GetMenu() => menu;
        public MainMenu()
        {
            InitializeComponent();
        }

        

        private void MainMenu_Load(object sender, EventArgs e)
        {
            menu.ShowPlanTable(); 
            menu.ShowCash();
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncomeForm = new AddIncomeForm();
            AddIncomeClass incomeClass = new AddIncomeClass(menu.Id, addIncomeForm, menu);
            addIncomeForm.SetClass(incomeClass);
            addIncomeForm.Show();
            menu.Cash = menu.GetCash();
            menu.ShowCash();
        }

        private void OutlayButton_Click(object sender, EventArgs e)
        {
            AddOutlayForm addOutlayForm = new AddOutlayForm();
            AddOutlayClass outlayClass = new AddOutlayClass(menu.Id, addOutlayForm, menu);
            addOutlayForm.SetClass(outlayClass);
            addOutlayForm.Show();
            menu.Cash = menu.GetCash();
            menu.ShowCash();
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

        private void SetIncomesOutlaysButton_Click(object sender, EventArgs e)
        {
            OutlayAndIncomeTypesForm form = new OutlayAndIncomeTypesForm();
            OutlayAndIncomeClass formClass = new OutlayAndIncomeClass(form, menu);
            form.SetClass(formClass);
            form.Show();
        }

        private void EditPlanButton_Click(object sender, EventArgs e)
        {
            PlanForm form = new PlanForm();
            form.Show();
        }
    }
}
