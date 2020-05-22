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
    public partial class AddOutlayForm : Form
    {
        AddOutlayClass addOutlay;
        public void SetClass(AddOutlayClass someClass) => addOutlay = someClass;
        public AddOutlayForm()
        {
            InitializeComponent();
        }

        private void AddOutlayForm_Load(object sender, EventArgs e)
        {
            addOutlay.ShowOutlayTypes();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            addOutlay.Add();
        }
    }
}
