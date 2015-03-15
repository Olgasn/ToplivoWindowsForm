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
    public partial class FormTank : Form
    {
        public FormTank()
        {
            InitializeComponent();
        }

        private void tanksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tanksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toplivo_DataSet);

        }

        private void FormTank_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Tanks". При необходимости она может быть перемещена или удалена.
            this.tanksTableAdapter.Fill(this.toplivo_DataSet.Tanks);

        }

        private void tankVolumeLabel_Click(object sender, EventArgs e)
        {

        }

        private void tankMaterialLabel_Click(object sender, EventArgs e)
        {

        }

        private void tankTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void tankWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void tankIDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
