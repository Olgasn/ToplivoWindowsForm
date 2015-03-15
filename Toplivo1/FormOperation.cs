using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toplivo1
{
    public partial class FormOperation : Form
    {
        public FormOperation()
        {
            InitializeComponent();
        }

        private void operationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.operationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toplivo_DataSet);

        }

        private void FormOperation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Tanks". При необходимости она может быть перемещена или удалена.
            this.tanksTableAdapter.Fill(this.toplivo_DataSet.Tanks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Fuels". При необходимости она может быть перемещена или удалена.
            this.fuelsTableAdapter.Fill(this.toplivo_DataSet.Fuels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.toplivo_DataSet.Operations);

        }
    }
}
