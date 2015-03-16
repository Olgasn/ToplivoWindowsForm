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
    public partial class FormFuel : Form
    {
        public FormFuel()
        {
            InitializeComponent();
        }

        private void fuelsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fuelsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toplivo_DataSet);

        }

        private void FormFuel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Fuels". При необходимости она может быть перемещена или удалена.
            this.fuelsTableAdapter.Fill(this.toplivo_DataSet.Fuels);

        }

        private void FormFuel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
