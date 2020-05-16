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
        public OutlayAndIncomeTypesForm()
        {
            InitializeComponent();
        }

        private void OutlayAndIncomeTypesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseUML.Outlay_Types". При необходимости она может быть перемещена или удалена.
            this.outlay_TypesTableAdapter.Fill(this.dataBaseUML.Outlay_Types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseUML.Income_Types". При необходимости она может быть перемещена или удалена.
            this.income_TypesTableAdapter.Fill(this.dataBaseUML.Income_Types);

        }
    }
}
