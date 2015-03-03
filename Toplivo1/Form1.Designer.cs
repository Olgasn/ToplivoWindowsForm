namespace Toplivo1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tanksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toplivo_DataSet = new Toplivo1.Toplivo_DataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fuelsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Емкость = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tanksBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.operationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fuelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tanksTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.TanksTableAdapter();
            this.tableAdapterManager = new Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager();
            this.fuelsTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.FuelsTableAdapter();
            this.operationsTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.OperationsTableAdapter();
            this.tanksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tanksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tanksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingNavigator)).BeginInit();
            this.tanksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 390);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tanksDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Емкости";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tanksDataGridView
            // 
            this.tanksDataGridView.AutoGenerateColumns = false;
            this.tanksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tanksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tanksDataGridView.DataSource = this.tanksBindingSource;
            this.tanksDataGridView.Location = new System.Drawing.Point(6, 70);
            this.tanksDataGridView.Name = "tanksDataGridView";
            this.tanksDataGridView.Size = new System.Drawing.Size(754, 263);
            this.tanksDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TankID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TankID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TankType";
            this.dataGridViewTextBoxColumn2.HeaderText = "TankType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TankVolume";
            this.dataGridViewTextBoxColumn3.HeaderText = "TankVolume";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TankWeight";
            this.dataGridViewTextBoxColumn4.HeaderText = "TankWeight";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TankMaterial";
            this.dataGridViewTextBoxColumn5.HeaderText = "TankMaterial";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tanksBindingSource
            // 
            this.tanksBindingSource.DataMember = "Tanks";
            this.tanksBindingSource.DataSource = this.toplivo_DataSet;
            // 
            // toplivo_DataSet
            // 
            this.toplivo_DataSet.DataSetName = "Toplivo_DataSet";
            this.toplivo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.fuelsDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Виды топлива";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fuelsDataGridView
            // 
            this.fuelsDataGridView.AutoGenerateColumns = false;
            this.fuelsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fuelsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.fuelsDataGridView.DataSource = this.fuelsBindingSource;
            this.fuelsDataGridView.Location = new System.Drawing.Point(21, 66);
            this.fuelsDataGridView.Name = "fuelsDataGridView";
            this.fuelsDataGridView.Size = new System.Drawing.Size(688, 277);
            this.fuelsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FuelID";
            this.dataGridViewTextBoxColumn6.HeaderText = "FuelID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FuelType";
            this.dataGridViewTextBoxColumn7.HeaderText = "FuelType";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FuelDensity";
            this.dataGridViewTextBoxColumn8.HeaderText = "FuelDensity";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // fuelsBindingSource
            // 
            this.fuelsBindingSource.DataMember = "Fuels";
            this.fuelsBindingSource.DataSource = this.toplivo_DataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.Емкость);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.operationsDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1063, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Операции";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Емкость
            // 
            this.Емкость.AutoSize = true;
            this.Емкость.Location = new System.Drawing.Point(54, 34);
            this.Емкость.Name = "Емкость";
            this.Емкость.Size = new System.Drawing.Size(51, 13);
            this.Емкость.TabIndex = 2;
            this.Емкость.Text = "Емкость";
            this.Емкость.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tanksBindingSource2;
            this.comboBox1.DisplayMember = "TankType";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "TankID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // tanksBindingSource2
            // 
            this.tanksBindingSource2.DataMember = "Tanks";
            this.tanksBindingSource2.DataSource = this.toplivo_DataSet;
            // 
            // operationsDataGridView
            // 
            this.operationsDataGridView.AutoGenerateColumns = false;
            this.operationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.operationsDataGridView.DataSource = this.operationsBindingSource;
            this.operationsDataGridView.Location = new System.Drawing.Point(15, 102);
            this.operationsDataGridView.Name = "operationsDataGridView";
            this.operationsDataGridView.Size = new System.Drawing.Size(925, 256);
            this.operationsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OperationID";
            this.dataGridViewTextBoxColumn9.HeaderText = "OperationID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FuelID";
            this.dataGridViewTextBoxColumn10.DataSource = this.fuelsBindingSource1;
            this.dataGridViewTextBoxColumn10.DisplayMember = "FuelType";
            this.dataGridViewTextBoxColumn10.HeaderText = "FuelID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "FuelID";
            // 
            // fuelsBindingSource1
            // 
            this.fuelsBindingSource1.DataMember = "Fuels";
            this.fuelsBindingSource1.DataSource = this.toplivo_DataSet;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Inc_Exp";
            this.dataGridViewTextBoxColumn12.HeaderText = "Inc_Exp";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn13.HeaderText = "Date";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // operationsBindingSource
            // 
            this.operationsBindingSource.DataMember = "Operations";
            this.operationsBindingSource.DataSource = this.toplivo_DataSet;
            // 
            // tanksTableAdapter
            // 
            this.tanksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuelsTableAdapter = this.fuelsTableAdapter;
            this.tableAdapterManager.OperationsTableAdapter = this.operationsTableAdapter;
            this.tableAdapterManager.TanksTableAdapter = this.tanksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fuelsTableAdapter
            // 
            this.fuelsTableAdapter.ClearBeforeFill = true;
            // 
            // operationsTableAdapter
            // 
            this.operationsTableAdapter.ClearBeforeFill = true;
            // 
            // tanksBindingNavigator
            // 
            this.tanksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tanksBindingNavigator.BindingSource = this.tanksBindingSource;
            this.tanksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tanksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tanksBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tanksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tanksBindingNavigatorSaveItem});
            this.tanksBindingNavigator.Location = new System.Drawing.Point(0, 581);
            this.tanksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tanksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tanksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tanksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tanksBindingNavigator.Name = "tanksBindingNavigator";
            this.tanksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tanksBindingNavigator.Size = new System.Drawing.Size(1095, 25);
            this.tanksBindingNavigator.TabIndex = 1;
            this.tanksBindingNavigator.Text = "bindingNavigator1";
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
            // tanksBindingNavigatorSaveItem
            // 
            this.tanksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tanksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tanksBindingNavigatorSaveItem.Image")));
            this.tanksBindingNavigatorSaveItem.Name = "tanksBindingNavigatorSaveItem";
            this.tanksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tanksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tanksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tanksBindingNavigatorSaveItem_Click);
            // 
            // tanksBindingSource1
            // 
            this.tanksBindingSource1.DataMember = "Tanks";
            this.tanksBindingSource1.DataSource = this.toplivo_DataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Операции с емкостями и топливом";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Виды топлива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Емкости для хранения топлива";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 606);
            this.Controls.Add(this.tanksBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Топливная база";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingNavigator)).EndInit();
            this.tanksBindingNavigator.ResumeLayout(false);
            this.tanksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Toplivo_DataSet toplivo_DataSet;
        private System.Windows.Forms.BindingSource tanksBindingSource;
        private Toplivo_DataSetTableAdapters.TanksTableAdapter tanksTableAdapter;
        private Toplivo_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tanksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tanksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tanksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Toplivo_DataSetTableAdapters.FuelsTableAdapter fuelsTableAdapter;
        private System.Windows.Forms.BindingSource fuelsBindingSource;
        private System.Windows.Forms.DataGridView fuelsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Toplivo_DataSetTableAdapters.OperationsTableAdapter operationsTableAdapter;
        private System.Windows.Forms.BindingSource operationsBindingSource;
        private System.Windows.Forms.DataGridView operationsDataGridView;
        private System.Windows.Forms.BindingSource fuelsBindingSource1;
        private System.Windows.Forms.BindingSource tanksBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tanksBindingSource2;
        private System.Windows.Forms.Label Емкость;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

