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

        private void BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            this.Validate();

            switch (this.tabControl1.SelectedIndex)
            {

                case 0:
                    this.tanksBindingSource.EndEdit();
                    break;
                case 1:
                    this.fuelsBindingSource.EndEdit();
                    break;
                case 2:
                    this.operationsBindingSource.EndEdit();
                    break;

            }
                

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





        private void comboBoxTankID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterOperations();
        }

        private void textBoxFindTankType_TextChanged(object sender, EventArgs e)
        {
            string strFilterTank = "TankType LIKE '";
            strFilterTank = strFilterTank + textBoxFindTankType.Text + "%'";

            tanksBindingSource.Filter = strFilterTank;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedIndex)
            {

                case 0:
                    BindingNavigator.BindingSource=tanksBindingSource;
                    break;
                case 1:
                    BindingNavigator.BindingSource=fuelsBindingSource;
                    break;
                case 2:
                    BindingNavigator.BindingSource=operationsBindingSource;
                    break;

            }
        }

        private void textBoxFindFuelType_TextChanged(object sender, EventArgs e)
        {
            FilterOperations();
        }

       

        private void checkBoxAll_Click(object sender, EventArgs e)
        {
            
            
        }

        private void FilterOperations()
        {
            string strFilterOperation = "TankID=";
            strFilterOperation = strFilterOperation + comboBoxTankID.SelectedValue;

            operationsBindingSource.Filter = strFilterOperation;

        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                comboBoxTankID.Enabled = false;
                operationsBindingSource.RemoveFilter();

            }
            else
            {
                comboBoxTankID.Enabled = true;
                FilterOperations();
                this.Update();
            }
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            FormOperation Form2 = new FormOperation();
            Form2.Show();
        }
        
        
    }
}
