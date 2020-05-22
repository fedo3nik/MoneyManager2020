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
    public partial class OutlayAndIncomeTypesForm : Form
    {
        OutlayAndIncomeClass activeClass;
        public void SetClass(OutlayAndIncomeClass someClass) => activeClass = someClass;
        public OutlayAndIncomeTypesForm()
        {
            InitializeComponent();
        }

        private void OutlayAndIncomeTypesForm_Load(object sender, EventArgs e)
        {
            activeClass.ShowOutlayTypes();
            activeClass.ShowIncomesTypes();
        }

        private void AddIncomeButton_Click(object sender, EventArgs e)
        {
            activeClass.AddIncomeType();
        }

        private void AddOutlayButton_Click(object sender, EventArgs e)
        {
            activeClass.AddOutlayType();
        }

        private void DeleteIncomeButton_Click(object sender, EventArgs e)
        {
            activeClass.DeleteIncomeType();
        }

        private void DeleteOutlayButton_Click(object sender, EventArgs e)
        {
            activeClass.DeleteOutlayType();
        }
    }
}
