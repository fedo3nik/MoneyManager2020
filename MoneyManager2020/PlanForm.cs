using MoneyManager2020.FormsClasses;
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
    public partial class PlanForm : Form
    {
        PlanClass activeClass;

        public void SetClass(PlanClass someClass) => activeClass = someClass;
        public PlanForm()
        {
            InitializeComponent();
        }

        private void PlanForm_Load(object sender, EventArgs e)
        {
            activeClass.ShowPlan();
            activeClass.ShowTypes();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            activeClass.Add();
            activeClass.ActiveMenu.ShowPlanTable();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            activeClass.Delete();
            activeClass.ActiveMenu.ShowPlanTable();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            activeClass.Update();
            activeClass.ActiveMenu.ShowPlanTable();
        }
    }
}
