using System;
using System.Windows.Forms;

namespace Toplivo1
{
    public partial class Form1 : Form
    {

        //Для работы с формами FormTank и FormFuel из формы Form1
        FormTank formtank;
        FormFuel formfuel;

        
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
            string strFilterFuel = "FuelType LIKE '";
            strFilterFuel = strFilterFuel + textBoxFindFuelType.Text + "%'";

            fuelsBindingSource.Filter = strFilterFuel;
        }

 
        private void FilterOperations()
        {
            string strFilterOperations = "";
            string strFilterFuel = "";
            string strFilterTank = "";

            if (comboBoxTankID.SelectedValue != null & !checkBoxAllTanks.Checked)
            {
                strFilterFuel = comboBoxTankID.SelectedValue.ToString();
                strFilterFuel = "TankID=" + strFilterFuel;
            }
            if (comboBoxFuelID.SelectedValue != null & !checkBoxAllFuels.Checked)
            {
                if (strFilterFuel != "") strFilterFuel += " AND ";
                strFilterTank = comboBoxFuelID.SelectedValue.ToString();
                strFilterTank = "FuelID=" + strFilterTank;
            }
            strFilterOperations = strFilterFuel + strFilterTank;
            operationsBindingSource.Filter = strFilterOperations;

        }

        private void checkBoxAllTanks_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllTanks.Checked)
            {
                comboBoxTankID.Enabled = false;
                operationsDataGridView.Columns["TankID"].Visible = true;
                operationsBindingSource.RemoveFilter();

            }
            else
            {
                comboBoxTankID.Enabled = true;
                operationsDataGridView.Columns["TankID"].Visible = false;
                FilterOperations();
                this.Update();
            }
        }

        private void checkBoxAllFuels_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllFuels.Checked)
            {
                comboBoxFuelID.Enabled = false;
                operationsDataGridView.Columns["FuelID"].Visible = true;
                operationsBindingSource.RemoveFilter();

            }
            else
            {
                comboBoxFuelID.Enabled = true;
                operationsDataGridView.Columns["FuelID"].Visible = false;
                FilterOperations();
                this.Update();
            }
        }

        private void buttonOpenFormTank_Click(object sender, EventArgs e)
        {

            string strFilterTank = tanksDataGridView[0, tanksDataGridView.CurrentRow.Index].Value.ToString();
            formtank = new FormTank();
            formtank.tanksBindingSource.Filter = "TankID=" + strFilterTank;

            formtank.ShowDialog();
            this.tanksTableAdapter.Fill(this.toplivo_DataSet.Tanks);

            this.tanksDataGridView.Refresh();
        }
        
        private void buttonOpenFormFuel_Click(object sender, EventArgs e)
        {
            string strFilterFuel = fuelsDataGridView[0, fuelsDataGridView.CurrentRow.Index].Value.ToString();
            
            formfuel = new FormFuel();
            formfuel.fuelsBindingSource.Filter = "FuelID=" + strFilterFuel;

            formfuel.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        }

        
    }
}
