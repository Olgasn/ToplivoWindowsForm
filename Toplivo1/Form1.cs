using System;
using System.Windows.Forms;

namespace Toplivo
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

            Validate();

            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    tanksBindingSource.EndEdit();
                    break;
                case 1:
                    fuelsBindingSource.EndEdit();
                    break;
                case 2:
                    operationsBindingSource.EndEdit();
                    break;

            }


            tableAdapterManager.UpdateAll(toplivo_DataSet);

            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Operations". При необходимости она может быть перемещена или удалена.
            operationsTableAdapter.Fill(toplivo_DataSet.Operations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Fuels". При необходимости она может быть перемещена или удалена.
            fuelsTableAdapter.Fill(toplivo_DataSet.Fuels);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Tanks". При необходимости она может быть перемещена или удалена.
            tanksTableAdapter.Fill(toplivo_DataSet.Tanks);

        }



        private void comboBoxTankID_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            FilterOperations();
        }

        private void textBoxFindTankType_TextChanged(object sender, EventArgs e)
        {
            string strFilterTankType = "TankType LIKE '";
            strFilterTankType = strFilterTankType + textBoxFindTankType.Text + "%'";

            tanksBindingSource.Filter = strFilterTankType;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
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
            string strFilterFuelType = "FuelType LIKE '";
            strFilterFuelType = strFilterFuelType + textBoxFindFuelType.Text + "%'";

            fuelsBindingSource.Filter = strFilterFuelType;
        }

 
        private void FilterOperations()
        {
            string strFilterOperations = "";
            string strFilterFuelID = "";
            string strFilterTankID = "";


            if (comboBoxTankID.SelectedValue != null & !checkBoxAllTanks.Checked)
            {
                strFilterTankID = comboBoxTankID.SelectedValue.ToString();
                strFilterTankID = "TankID=" + strFilterTankID;
            }
            if (comboBoxFuelID.SelectedValue != null & !checkBoxAllFuels.Checked)
            {
                strFilterFuelID = comboBoxFuelID.SelectedValue.ToString();
                strFilterFuelID = "FuelID=" + strFilterFuelID;
            }


            strFilterOperations = strFilterFuelID;
            if (strFilterFuelID != "" & strFilterTankID != "")
                strFilterOperations = strFilterOperations+ " AND " + strFilterTankID;
            else if (strFilterTankID != "")
                strFilterOperations =  strFilterTankID;

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
            }
        }

        private void buttonOpenFormTank_Click(object sender, EventArgs e)
        {

            string strFilterTankID = tanksDataGridView[0, tanksDataGridView.CurrentRow.Index].Value.ToString();

            formtank = new FormTank();
            formtank.tanksBindingSource.Filter = "TankID=" + strFilterTankID;

            formtank.ShowDialog();

            //обновление после возврата в основную форму
            tanksTableAdapter.Fill(toplivo_DataSet.Tanks);
            tanksDataGridView.Refresh();
        }
        
        private void buttonOpenFormFuel_Click(object sender, EventArgs e)
        {
            string strFilterFuelID = fuelsDataGridView[0, fuelsDataGridView.CurrentRow.Index].Value.ToString();
            
            formfuel = new FormFuel();
            formfuel.fuelsBindingSource.Filter = "FuelID=" + strFilterFuelID;

            formfuel.ShowDialog();

            //обновление после возврата в основную форму
            fuelsTableAdapter.Fill(toplivo_DataSet.Fuels);
            fuelsDataGridView.Refresh();


        }

        private void comboBoxFuelID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterOperations();
        }
    }
}
