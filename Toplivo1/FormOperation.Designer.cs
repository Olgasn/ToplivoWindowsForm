namespace Toplivo1
{
    partial class FormOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label operationIDLabel;
            System.Windows.Forms.Label fuelIDLabel;
            System.Windows.Forms.Label tankIDLabel;
            System.Windows.Forms.Label inc_ExpLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperation));
            this.toplivo_DataSet = new Toplivo1.Toplivo_DataSet();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationsTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.OperationsTableAdapter();
            this.tableAdapterManager = new Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager();
            this.operationsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.operationsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.operationIDTextBox = new System.Windows.Forms.TextBox();
            this.fuelIDComboBox = new System.Windows.Forms.ComboBox();
            this.tankIDComboBox = new System.Windows.Forms.ComboBox();
            this.inc_ExpTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fuelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelsTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.FuelsTableAdapter();
            this.tanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanksTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.TanksTableAdapter();
            operationIDLabel = new System.Windows.Forms.Label();
            fuelIDLabel = new System.Windows.Forms.Label();
            tankIDLabel = new System.Windows.Forms.Label();
            inc_ExpLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingNavigator)).BeginInit();
            this.operationsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // operationIDLabel
            // 
            operationIDLabel.AutoSize = true;
            operationIDLabel.Location = new System.Drawing.Point(-2, 56);
            operationIDLabel.Name = "operationIDLabel";
            operationIDLabel.Size = new System.Drawing.Size(95, 13);
            operationIDLabel.TabIndex = 1;
            operationIDLabel.Text = "Номер операции:";
            // 
            // fuelIDLabel
            // 
            fuelIDLabel.AutoSize = true;
            fuelIDLabel.Location = new System.Drawing.Point(-2, 82);
            fuelIDLabel.Name = "fuelIDLabel";
            fuelIDLabel.Size = new System.Drawing.Size(130, 13);
            fuelIDLabel.TabIndex = 3;
            fuelIDLabel.Text = "Наименование топлива:";
            // 
            // tankIDLabel
            // 
            tankIDLabel.AutoSize = true;
            tankIDLabel.Location = new System.Drawing.Point(-2, 109);
            tankIDLabel.Name = "tankIDLabel";
            tankIDLabel.Size = new System.Drawing.Size(132, 13);
            tankIDLabel.TabIndex = 5;
            tankIDLabel.Text = "Наименование емкости:";
            // 
            // inc_ExpLabel
            // 
            inc_ExpLabel.AutoSize = true;
            inc_ExpLabel.Location = new System.Drawing.Point(-2, 136);
            inc_ExpLabel.Name = "inc_ExpLabel";
            inc_ExpLabel.Size = new System.Drawing.Size(118, 13);
            inc_ExpLabel.TabIndex = 7;
            inc_ExpLabel.Text = "Получено - Отпущено:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(-2, 163);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(87, 13);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Дата операции:";
            // 
            // toplivo_DataSet
            // 
            this.toplivo_DataSet.DataSetName = "Toplivo_DataSet";
            this.toplivo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "Operations";
            this.operationsBindingSource.DataSource = this.toplivo_DataSet;
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuelsTableAdapter = null;
            this.tableAdapterManager.OperationsTableAdapter = this.operationsTableAdapter;
            this.tableAdapterManager.TanksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // operationsBindingNavigator
            // 
            this.operationsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.operationsBindingNavigator.BindingSource = this.operationsBindingSource;
            this.operationsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.operationsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.operationsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.operationsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.operationsBindingNavigatorSaveItem});
            this.operationsBindingNavigator.Location = new System.Drawing.Point(0, 237);
            this.operationsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.operationsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.operationsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.operationsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.operationsBindingNavigator.Name = "operationsBindingNavigator";
            this.operationsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.operationsBindingNavigator.Size = new System.Drawing.Size(402, 25);
            this.operationsBindingNavigator.TabIndex = 0;
            this.operationsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // operationsBindingNavigatorSaveItem
            // 
            this.operationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.operationsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("operationsBindingNavigatorSaveItem.Image")));
            this.operationsBindingNavigatorSaveItem.Name = "operationsBindingNavigatorSaveItem";
            this.operationsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.operationsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.operationsBindingNavigatorSaveItem.Click += new System.EventHandler(this.operationsBindingNavigatorSaveItem_Click);
            // 
            // operationIDTextBox
            // 
            this.operationIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationsBindingSource, "OperationID", true));
            this.operationIDTextBox.Location = new System.Drawing.Point(126, 53);
            this.operationIDTextBox.Name = "operationIDTextBox";
            this.operationIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.operationIDTextBox.TabIndex = 2;
            // 
            // fuelIDComboBox
            // 
            this.fuelIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationsBindingSource, "FuelID", true));
            this.fuelIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operationsBindingSource, "FuelID", true));
            this.fuelIDComboBox.DataSource = this.fuelsBindingSource;
            this.fuelIDComboBox.DisplayMember = "FuelType";
            this.fuelIDComboBox.FormattingEnabled = true;
            this.fuelIDComboBox.Location = new System.Drawing.Point(126, 79);
            this.fuelIDComboBox.Name = "fuelIDComboBox";
            this.fuelIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.fuelIDComboBox.TabIndex = 4;
            this.fuelIDComboBox.ValueMember = "FuelID";
            // 
            // tankIDComboBox
            // 
            this.tankIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationsBindingSource, "TankID", true));
            this.tankIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.operationsBindingSource, "TankID", true));
            this.tankIDComboBox.DataSource = this.tanksBindingSource;
            this.tankIDComboBox.DisplayMember = "TankType";
            this.tankIDComboBox.FormattingEnabled = true;
            this.tankIDComboBox.Location = new System.Drawing.Point(126, 106);
            this.tankIDComboBox.Name = "tankIDComboBox";
            this.tankIDComboBox.Size = new System.Drawing.Size(200, 21);
            this.tankIDComboBox.TabIndex = 6;
            this.tankIDComboBox.ValueMember = "TankID";
            // 
            // inc_ExpTextBox
            // 
            this.inc_ExpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationsBindingSource, "Inc_Exp", true));
            this.inc_ExpTextBox.Location = new System.Drawing.Point(126, 133);
            this.inc_ExpTextBox.Name = "inc_ExpTextBox";
            this.inc_ExpTextBox.Size = new System.Drawing.Size(200, 20);
            this.inc_ExpTextBox.TabIndex = 8;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operationsBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(126, 159);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // fuelsBindingSource
            // 
            this.fuelsBindingSource.DataMember = "Fuels";
            this.fuelsBindingSource.DataSource = this.toplivo_DataSet;
            // 
            // fuelsTableAdapter
            // 
            this.fuelsTableAdapter.ClearBeforeFill = true;
            // 
            // tanksBindingSource
            // 
            this.tanksBindingSource.DataMember = "Tanks";
            this.tanksBindingSource.DataSource = this.toplivo_DataSet;
            // 
            // tanksTableAdapter
            // 
            this.tanksTableAdapter.ClearBeforeFill = true;
            // 
            // FormOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 262);
            this.Controls.Add(operationIDLabel);
            this.Controls.Add(this.operationIDTextBox);
            this.Controls.Add(fuelIDLabel);
            this.Controls.Add(this.fuelIDComboBox);
            this.Controls.Add(tankIDLabel);
            this.Controls.Add(this.tankIDComboBox);
            this.Controls.Add(inc_ExpLabel);
            this.Controls.Add(this.inc_ExpTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.operationsBindingNavigator);
            this.Name = "FormOperation";
            this.Text = "Операция";
            this.Load += new System.EventHandler(this.FormOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingNavigator)).EndInit();
            this.operationsBindingNavigator.ResumeLayout(false);
            this.operationsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Toplivo_DataSet toplivo_DataSet;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private Toplivo_DataSetTableAdapters.OperationsTableAdapter operationsTableAdapter;
        private Toplivo_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator operationsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton operationsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox operationIDTextBox;
        private System.Windows.Forms.ComboBox fuelIDComboBox;
        private System.Windows.Forms.ComboBox tankIDComboBox;
        private System.Windows.Forms.TextBox inc_ExpTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.BindingSource fuelsBindingSource;
        private Toplivo_DataSetTableAdapters.FuelsTableAdapter fuelsTableAdapter;
        private System.Windows.Forms.BindingSource tanksBindingSource;
        private Toplivo_DataSetTableAdapters.TanksTableAdapter tanksTableAdapter;
    }
}