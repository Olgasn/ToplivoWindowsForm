namespace Toplivo1
{
    partial class FormTank
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
            System.Windows.Forms.Label tankIDLabel;
            System.Windows.Forms.Label tankTypeLabel;
            System.Windows.Forms.Label tankVolumeLabel;
            System.Windows.Forms.Label tankWeightLabel;
            System.Windows.Forms.Label tankMaterialLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTank));
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
            this.tankIDTextBox = new System.Windows.Forms.TextBox();
            this.tankTypeTextBox = new System.Windows.Forms.TextBox();
            this.tankVolumeTextBox = new System.Windows.Forms.TextBox();
            this.tankWeightTextBox = new System.Windows.Forms.TextBox();
            this.tankMaterialTextBox = new System.Windows.Forms.TextBox();
            this.TankPictureBox = new System.Windows.Forms.PictureBox();
            this.tanksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toplivo_DataSet = new Toplivo1.Toplivo_DataSet();
            this.tanksTableAdapter = new Toplivo1.Toplivo_DataSetTableAdapters.TanksTableAdapter();
            this.tableAdapterManager = new Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager();
            tankIDLabel = new System.Windows.Forms.Label();
            tankTypeLabel = new System.Windows.Forms.Label();
            tankVolumeLabel = new System.Windows.Forms.Label();
            tankWeightLabel = new System.Windows.Forms.Label();
            tankMaterialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingNavigator)).BeginInit();
            this.tanksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TankPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tankIDLabel
            // 
            tankIDLabel.AutoSize = true;
            tankIDLabel.Location = new System.Drawing.Point(57, 73);
            tankIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tankIDLabel.Name = "tankIDLabel";
            tankIDLabel.Size = new System.Drawing.Size(55, 17);
            tankIDLabel.TabIndex = 1;
            tankIDLabel.Text = "Номер:";
            // 
            // tankTypeLabel
            // 
            tankTypeLabel.AutoSize = true;
            tankTypeLabel.Location = new System.Drawing.Point(57, 105);
            tankTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tankTypeLabel.Name = "tankTypeLabel";
            tankTypeLabel.Size = new System.Drawing.Size(110, 17);
            tankTypeLabel.TabIndex = 3;
            tankTypeLabel.Text = "Наименование:";
            // 
            // tankVolumeLabel
            // 
            tankVolumeLabel.AutoSize = true;
            tankVolumeLabel.Location = new System.Drawing.Point(57, 137);
            tankVolumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tankVolumeLabel.Name = "tankVolumeLabel";
            tankVolumeLabel.Size = new System.Drawing.Size(57, 17);
            tankVolumeLabel.TabIndex = 5;
            tankVolumeLabel.Text = "Объем:";
            // 
            // tankWeightLabel
            // 
            tankWeightLabel.AutoSize = true;
            tankWeightLabel.Location = new System.Drawing.Point(57, 169);
            tankWeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tankWeightLabel.Name = "tankWeightLabel";
            tankWeightLabel.Size = new System.Drawing.Size(36, 17);
            tankWeightLabel.TabIndex = 7;
            tankWeightLabel.Text = "Вес:";
            // 
            // tankMaterialLabel
            // 
            tankMaterialLabel.AutoSize = true;
            tankMaterialLabel.Location = new System.Drawing.Point(57, 201);
            tankMaterialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tankMaterialLabel.Name = "tankMaterialLabel";
            tankMaterialLabel.Size = new System.Drawing.Size(78, 17);
            tankMaterialLabel.TabIndex = 9;
            tankMaterialLabel.Text = "Материал:";
            // 
            // tanksBindingNavigator
            // 
            this.tanksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tanksBindingNavigator.BindingSource = this.tanksBindingSource;
            this.tanksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tanksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tanksBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tanksBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            this.tanksBindingNavigator.Location = new System.Drawing.Point(0, 295);
            this.tanksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tanksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tanksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tanksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tanksBindingNavigator.Name = "tanksBindingNavigator";
            this.tanksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tanksBindingNavigator.Size = new System.Drawing.Size(882, 27);
            this.tanksBindingNavigator.TabIndex = 0;
            this.tanksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tanksBindingNavigatorSaveItem
            // 
            this.tanksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tanksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tanksBindingNavigatorSaveItem.Image")));
            this.tanksBindingNavigatorSaveItem.Name = "tanksBindingNavigatorSaveItem";
            this.tanksBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tanksBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tanksBindingNavigatorSaveItem.Click += new System.EventHandler(this.tanksBindingNavigatorSaveItem_Click);
            // 
            // tankIDTextBox
            // 
            this.tankIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tanksBindingSource, "TankID", true));
            this.tankIDTextBox.Location = new System.Drawing.Point(204, 73);
            this.tankIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tankIDTextBox.Name = "tankIDTextBox";
            this.tankIDTextBox.Size = new System.Drawing.Size(201, 22);
            this.tankIDTextBox.TabIndex = 2;
            // 
            // tankTypeTextBox
            // 
            this.tankTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tanksBindingSource, "TankType", true));
            this.tankTypeTextBox.Location = new System.Drawing.Point(204, 105);
            this.tankTypeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tankTypeTextBox.Name = "tankTypeTextBox";
            this.tankTypeTextBox.Size = new System.Drawing.Size(201, 22);
            this.tankTypeTextBox.TabIndex = 4;
            // 
            // tankVolumeTextBox
            // 
            this.tankVolumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tanksBindingSource, "TankVolume", true));
            this.tankVolumeTextBox.Location = new System.Drawing.Point(204, 137);
            this.tankVolumeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tankVolumeTextBox.Name = "tankVolumeTextBox";
            this.tankVolumeTextBox.Size = new System.Drawing.Size(201, 22);
            this.tankVolumeTextBox.TabIndex = 6;
            // 
            // tankWeightTextBox
            // 
            this.tankWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tanksBindingSource, "TankWeight", true));
            this.tankWeightTextBox.Location = new System.Drawing.Point(204, 169);
            this.tankWeightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tankWeightTextBox.Name = "tankWeightTextBox";
            this.tankWeightTextBox.Size = new System.Drawing.Size(201, 22);
            this.tankWeightTextBox.TabIndex = 8;
            // 
            // tankMaterialTextBox
            // 
            this.tankMaterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tanksBindingSource, "TankMaterial", true));
            this.tankMaterialTextBox.Location = new System.Drawing.Point(204, 201);
            this.tankMaterialTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tankMaterialTextBox.Name = "tankMaterialTextBox";
            this.tankMaterialTextBox.Size = new System.Drawing.Size(201, 22);
            this.tankMaterialTextBox.TabIndex = 10;
            // 
            // TankPictureBox
            // 
            this.TankPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tanksBindingSource, "TankPicture", true));
            this.TankPictureBox.Location = new System.Drawing.Point(434, 73);
            this.TankPictureBox.Name = "TankPictureBox";
            this.TankPictureBox.Size = new System.Drawing.Size(385, 150);
            this.TankPictureBox.TabIndex = 11;
            this.TankPictureBox.TabStop = false;
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
            // tanksTableAdapter
            // 
            this.tanksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FuelsTableAdapter = null;
            this.tableAdapterManager.OperationsTableAdapter = null;
            this.tableAdapterManager.TanksTableAdapter = this.tanksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Toplivo1.Toplivo_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 322);
            this.Controls.Add(this.TankPictureBox);
            this.Controls.Add(tankIDLabel);
            this.Controls.Add(this.tankIDTextBox);
            this.Controls.Add(tankTypeLabel);
            this.Controls.Add(this.tankTypeTextBox);
            this.Controls.Add(tankVolumeLabel);
            this.Controls.Add(this.tankVolumeTextBox);
            this.Controls.Add(tankWeightLabel);
            this.Controls.Add(this.tankWeightTextBox);
            this.Controls.Add(tankMaterialLabel);
            this.Controls.Add(this.tankMaterialTextBox);
            this.Controls.Add(this.tanksBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTank";
            this.Text = "Емкость";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTank_FormClosing);
            this.Load += new System.EventHandler(this.FormTank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingNavigator)).EndInit();
            this.tanksBindingNavigator.ResumeLayout(false);
            this.tanksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TankPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tanksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplivo_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Toplivo_DataSet toplivo_DataSet;
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
        private System.Windows.Forms.TextBox tankIDTextBox;
        private System.Windows.Forms.TextBox tankTypeTextBox;
        private System.Windows.Forms.TextBox tankVolumeTextBox;
        private System.Windows.Forms.TextBox tankWeightTextBox;
        private System.Windows.Forms.TextBox tankMaterialTextBox;
        protected internal System.Windows.Forms.BindingSource tanksBindingSource;
        private System.Windows.Forms.PictureBox TankPictureBox;
    }
}