using System;
using System.Data;
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
            Validate();
            fuelsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(toplivo_DataSet);

        }

        private void FormFuel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Operations". При необходимости она может быть перемещена или удалена.
            operationsTableAdapter.Fill(toplivo_DataSet.Operations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toplivo_DataSet.Fuels". При необходимости она может быть перемещена или удалена.
            fuelsTableAdapter.Fill(toplivo_DataSet.Fuels);


            //Установить связь между двумя таблицами
            DataRelation relation = new DataRelation("FuelsOperations",
                toplivo_DataSet.Tables["Fuels"].Columns["FuelID"],
                toplivo_DataSet.Tables["Operations"].Columns["FuelID"]);
                toplivo_DataSet.Relations.Add(relation);

            
            // Bind the details data connector to the master data connector,
            // using the DataRelation name to filter the information in the 
            // details table based on the current row in the master table. 
            operationsBindingSource.DataSource = fuelsBindingSource;
            operationsBindingSource.DataMember = "FuelsOperations";

        }

        private void FormFuel_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                operationsTableAdapter.FillBy(toplivo_DataSet.Operations);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonShowAllRecords_Click(object sender, EventArgs e)
        {
            fuelsBindingSource.RemoveFilter();
        }
    }
}
