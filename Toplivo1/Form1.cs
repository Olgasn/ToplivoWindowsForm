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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tanksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tanksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.toplivo_DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Operations". При необходимости она может быть перемещена или удалена.
            this.operationsTableAdapter.Fill(this.toplivo_DataSet.Operations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Fuels". При необходимости она может быть перемещена или удалена.
            this.fuelsTableAdapter.Fill(this.toplivo_DataSet.Fuels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Tanks". При необходимости она может быть перемещена или удалена.
            this.tanksTableAdapter.Fill(this.toplivo_DataSet.Tanks);

        }

        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strFilterOperation = "TankID=";
            strFilterOperation = strFilterOperation + comboBox1.SelectedValue;

            operationsBindingSource.Filter = strFilterOperation;
        }

        private void textBoxFindTankType_TextChanged(object sender, EventArgs e)
        {
            string strFilterOperation = "TankType LIKE '";
            strFilterOperation = strFilterOperation + textBoxFindTankType.Text + "%'";

            tanksBindingSource.Filter = strFilterOperation;
        }

        
        
    }
}
