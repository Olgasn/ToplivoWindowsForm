namespace Toplivo1
{
    partial class FormFuel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFuel));
            System.Windows.Forms.Label fuelIDLabel;
            System.Windows.Forms.Label fuelTypeLabel;
            System.Windows.Forms.Label fuelDensityLabel;
            this.toplivo_DataSet = new Toplivo1.Toplivo_DataSet();
            this.fuelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuelsTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.FuelsTableAdapter();
            this.tableAdapterManager = new Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager();
            this.fuelsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.fuelsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fuelIDTextBox = new System.Windows.Forms.TextBox();
            this.fuelTypeTextBox = new System.Windows.Forms.TextBox();
            this.fuelDensityTextBox = new System.Windows.Forms.TextBox();
            fuelIDLabel = new System.Windows.Forms.Label();
            fuelTypeLabel = new System.Windows.Forms.Label();
            fuelDensityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingNavigator)).BeginInit();
            this.fuelsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // toplivo_DataSet
            // 
            this.toplivo_DataSet.DataSetName = "Toplivo_DataSet";
            this.toplivo_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuelsTableAdapter = this.fuelsTableAdapter;
            this.tableAdapterManager.OperationsTableAdapter = null;
            this.tableAdapterManager.TanksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fuelsBindingNavigator
            // 
            this.fuelsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fuelsBindingNavigator.BindingSource = this.fuelsBindingSource;
            this.fuelsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fuelsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fuelsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.fuelsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fuelsBindingNavigatorSaveItem});
            this.fuelsBindingNavigator.Location = new System.Drawing.Point(0, 237);
            this.fuelsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fuelsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fuelsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fuelsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fuelsBindingNavigator.Name = "fuelsBindingNavigator";
            this.fuelsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fuelsBindingNavigator.Size = new System.Drawing.Size(373, 25);
            this.fuelsBindingNavigator.TabIndex = 0;
            this.fuelsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // fuelsBindingNavigatorSaveItem
            // 
            this.fuelsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fuelsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fuelsBindingNavigatorSaveItem.Image")));
            this.fuelsBindingNavigatorSaveItem.Name = "fuelsBindingNavigatorSaveItem";
            this.fuelsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.fuelsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.fuelsBindingNavigatorSaveItem.Click += new System.EventHandler(this.fuelsBindingNavigatorSaveItem_Click);
            // 
            // fuelIDLabel
            // 
            fuelIDLabel.AutoSize = true;
            fuelIDLabel.Location = new System.Drawing.Point(53, 54);
            fuelIDLabel.Name = "fuelIDLabel";
            fuelIDLabel.Size = new System.Drawing.Size(44, 13);
            fuelIDLabel.TabIndex = 1;
            fuelIDLabel.Text = "Номер:";
            // 
            // fuelIDTextBox
            // 
            this.fuelIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelsBindingSource, "FuelID", true));
            this.fuelIDTextBox.Location = new System.Drawing.Point(144, 51);
            this.fuelIDTextBox.Name = "fuelIDTextBox";
            this.fuelIDTextBox.Size = new System.Drawing.Size(154, 20);
            this.fuelIDTextBox.TabIndex = 2;
            // 
            // fuelTypeLabel
            // 
            fuelTypeLabel.AutoSize = true;
            fuelTypeLabel.Location = new System.Drawing.Point(53, 80);
            fuelTypeLabel.Name = "fuelTypeLabel";
            fuelTypeLabel.Size = new System.Drawing.Size(86, 13);
            fuelTypeLabel.TabIndex = 3;
            fuelTypeLabel.Text = "Наименование:";
            // 
            // fuelTypeTextBox
            // 
            this.fuelTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelsBindingSource, "FuelType", true));
            this.fuelTypeTextBox.Location = new System.Drawing.Point(144, 77);
            this.fuelTypeTextBox.Name = "fuelTypeTextBox";
            this.fuelTypeTextBox.Size = new System.Drawing.Size(154, 20);
            this.fuelTypeTextBox.TabIndex = 4;
            // 
            // fuelDensityLabel
            // 
            fuelDensityLabel.AutoSize = true;
            fuelDensityLabel.Location = new System.Drawing.Point(53, 106);
            fuelDensityLabel.Name = "fuelDensityLabel";
            fuelDensityLabel.Size = new System.Drawing.Size(64, 13);
            fuelDensityLabel.TabIndex = 5;
            fuelDensityLabel.Text = "Плотность:";
            // 
            // fuelDensityTextBox
            // 
            this.fuelDensityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelsBindingSource, "FuelDensity", true));
            this.fuelDensityTextBox.Location = new System.Drawing.Point(144, 103);
            this.fuelDensityTextBox.Name = "fuelDensityTextBox";
            this.fuelDensityTextBox.Size = new System.Drawing.Size(154, 20);
            this.fuelDensityTextBox.TabIndex = 6;
            // 
            // FormFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 262);
            this.Controls.Add(fuelIDLabel);
            this.Controls.Add(this.fuelIDTextBox);
            this.Controls.Add(fuelTypeLabel);
            this.Controls.Add(this.fuelTypeTextBox);
            this.Controls.Add(fuelDensityLabel);
            this.Controls.Add(this.fuelDensityTextBox);
            this.Controls.Add(this.fuelsBindingNavigator);
            this.Name = "FormFuel";
            this.Text = "Топливо";
            this.Load += new System.EventHandler(this.FormFuel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelsBindingNavigator)).EndInit();
            this.fuelsBindingNavigator.ResumeLayout(false);
            this.fuelsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Toplivo_DataSet toplivo_DataSet;
        private System.Windows.Forms.BindingSource fuelsBindingSource;
        private Toplivo_DataSetTableAdapters.FuelsTableAdapter fuelsTableAdapter;
        private Toplivo_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fuelsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fuelsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fuelIDTextBox;
        private System.Windows.Forms.TextBox fuelTypeTextBox;
        private System.Windows.Forms.TextBox fuelDensityTextBox;
    }
}