namespace lastYearExamse_prep
{
    partial class Form1
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
            System.Windows.Forms.Label moduleCodeLabel;
            System.Windows.Forms.Label moduleNameLabel;
            System.Windows.Forms.Label moduleYearLabel;
            System.Windows.Forms.Label moduleTypeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.universityDataSet = new lastYearExamse_prep.UniversityDataSet();
            this.tb_ModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ModuleTableAdapter = new lastYearExamse_prep.UniversityDataSetTableAdapters.tb_ModuleTableAdapter();
            this.tableAdapterManager = new lastYearExamse_prep.UniversityDataSetTableAdapters.TableAdapterManager();
            this.tb_ModuleTypeTableAdapter = new lastYearExamse_prep.UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter();
            this.tb_ModuleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_ModuleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.moduleCodeTextBox = new System.Windows.Forms.TextBox();
            this.moduleNameTextBox = new System.Windows.Forms.TextBox();
            this.moduleYearTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbModuleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxModelName = new System.Windows.Forms.TextBox();
            this.tbxModelYear = new System.Windows.Forms.TextBox();
            this.tbxModelCode = new System.Windows.Forms.TextBox();
            this.cbxModelType = new System.Windows.Forms.ComboBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbModuleTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbxFilter = new System.Windows.Forms.TextBox();
            moduleCodeLabel = new System.Windows.Forms.Label();
            moduleNameLabel = new System.Windows.Forms.Label();
            moduleYearLabel = new System.Windows.Forms.Label();
            moduleTypeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).BeginInit();
            this.tb_ModuleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleCodeLabel
            // 
            moduleCodeLabel.AutoSize = true;
            moduleCodeLabel.Location = new System.Drawing.Point(158, 87);
            moduleCodeLabel.Name = "moduleCodeLabel";
            moduleCodeLabel.Size = new System.Drawing.Size(91, 16);
            moduleCodeLabel.TabIndex = 3;
            moduleCodeLabel.Text = "Module Code:";
            // 
            // moduleNameLabel
            // 
            moduleNameLabel.AutoSize = true;
            moduleNameLabel.Location = new System.Drawing.Point(158, 131);
            moduleNameLabel.Name = "moduleNameLabel";
            moduleNameLabel.Size = new System.Drawing.Size(95, 16);
            moduleNameLabel.TabIndex = 5;
            moduleNameLabel.Text = "Module Name:";
            moduleNameLabel.Click += new System.EventHandler(this.moduleNameLabel_Click);
            // 
            // moduleYearLabel
            // 
            moduleYearLabel.AutoSize = true;
            moduleYearLabel.Location = new System.Drawing.Point(158, 159);
            moduleYearLabel.Name = "moduleYearLabel";
            moduleYearLabel.Size = new System.Drawing.Size(87, 16);
            moduleYearLabel.TabIndex = 7;
            moduleYearLabel.Text = "Module Year:";
            // 
            // moduleTypeLabel
            // 
            moduleTypeLabel.AutoSize = true;
            moduleTypeLabel.Location = new System.Drawing.Point(158, 197);
            moduleTypeLabel.Name = "moduleTypeLabel";
            moduleTypeLabel.Size = new System.Drawing.Size(90, 16);
            moduleTypeLabel.TabIndex = 9;
            moduleTypeLabel.Text = "Module Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(67, 143);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 16);
            label1.TabIndex = 9;
            label1.Text = "Module Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(67, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 16);
            label2.TabIndex = 7;
            label2.Text = "Module Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(67, 77);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 16);
            label3.TabIndex = 5;
            label3.Text = "Module Name:";
            label3.Click += new System.EventHandler(this.moduleNameLabel_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(67, 33);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(91, 16);
            label4.TabIndex = 3;
            label4.Text = "Module Code:";
            // 
            // universityDataSet
            // 
            this.universityDataSet.DataSetName = "UniversityDataSet";
            this.universityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ModuleBindingSource
            // 
            this.tb_ModuleBindingSource.DataMember = "tb_Module";
            this.tb_ModuleBindingSource.DataSource = this.universityDataSet;
            this.tb_ModuleBindingSource.CurrentChanged += new System.EventHandler(this.tb_ModuleBindingSource_CurrentChanged);
            // 
            // tb_ModuleTableAdapter
            // 
            this.tb_ModuleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ModuleTableAdapter = this.tb_ModuleTableAdapter;
            this.tableAdapterManager.tb_ModuleTypeTableAdapter = this.tb_ModuleTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = lastYearExamse_prep.UniversityDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ModuleTypeTableAdapter
            // 
            this.tb_ModuleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ModuleBindingNavigator
            // 
            this.tb_ModuleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ModuleBindingNavigator.BindingSource = this.tb_ModuleBindingSource;
            this.tb_ModuleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ModuleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ModuleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tb_ModuleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_ModuleBindingNavigatorSaveItem});
            this.tb_ModuleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ModuleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ModuleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ModuleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ModuleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ModuleBindingNavigator.Name = "tb_ModuleBindingNavigator";
            this.tb_ModuleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ModuleBindingNavigator.Size = new System.Drawing.Size(1092, 27);
            this.tb_ModuleBindingNavigator.TabIndex = 0;
            this.tb_ModuleBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tb_ModuleBindingNavigatorSaveItem
            // 
            this.tb_ModuleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ModuleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ModuleBindingNavigatorSaveItem.Image")));
            this.tb_ModuleBindingNavigatorSaveItem.Name = "tb_ModuleBindingNavigatorSaveItem";
            this.tb_ModuleBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tb_ModuleBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ModuleBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ModuleBindingNavigatorSaveItem_Click);
            // 
            // moduleCodeTextBox
            // 
            this.moduleCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleCode", true));
            this.moduleCodeTextBox.Location = new System.Drawing.Point(259, 84);
            this.moduleCodeTextBox.Name = "moduleCodeTextBox";
            this.moduleCodeTextBox.Size = new System.Drawing.Size(148, 22);
            this.moduleCodeTextBox.TabIndex = 4;
            // 
            // moduleNameTextBox
            // 
            this.moduleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleName", true));
            this.moduleNameTextBox.Location = new System.Drawing.Point(259, 125);
            this.moduleNameTextBox.Name = "moduleNameTextBox";
            this.moduleNameTextBox.Size = new System.Drawing.Size(148, 22);
            this.moduleNameTextBox.TabIndex = 6;
            // 
            // moduleYearTextBox
            // 
            this.moduleYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ModuleBindingSource, "ModuleYear", true));
            this.moduleYearTextBox.Location = new System.Drawing.Point(259, 156);
            this.moduleYearTextBox.Name = "moduleYearTextBox";
            this.moduleYearTextBox.Size = new System.Drawing.Size(148, 22);
            this.moduleYearTextBox.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tb_ModuleBindingSource;
            this.listBox1.DisplayMember = "ModuleName";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 180);
            this.listBox1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ModuleBindingSource, "ModuleType", true));
            this.comboBox1.DataSource = this.tbModuleTypeBindingSource;
            this.comboBox1.DisplayMember = "ModuleTypeName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "ID";
            // 
            // tbModuleTypeBindingSource
            // 
            this.tbModuleTypeBindingSource.DataMember = "tb_ModuleType";
            this.tbModuleTypeBindingSource.DataSource = this.universityDataSet;
            // 
            // universityDataSetBindingSource
            // 
            this.universityDataSetBindingSource.DataSource = this.universityDataSet;
            this.universityDataSetBindingSource.Position = 0;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 270);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(39, 23);
            this.btnFirst.TabIndex = 13;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(89, 270);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(121, 270);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(42, 23);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(203, 241);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 32);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(308, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 32);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxModelName);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.tbxModelYear);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.tbxModelCode);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.cbxModelType);
            this.groupBox1.Location = new System.Drawing.Point(546, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 241);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Module";
            // 
            // tbxModelName
            // 
            this.tbxModelName.Location = new System.Drawing.Point(168, 71);
            this.tbxModelName.Name = "tbxModelName";
            this.tbxModelName.Size = new System.Drawing.Size(148, 22);
            this.tbxModelName.TabIndex = 6;
            // 
            // tbxModelYear
            // 
            this.tbxModelYear.Location = new System.Drawing.Point(168, 102);
            this.tbxModelYear.Name = "tbxModelYear";
            this.tbxModelYear.Size = new System.Drawing.Size(148, 22);
            this.tbxModelYear.TabIndex = 8;
            // 
            // tbxModelCode
            // 
            this.tbxModelCode.Location = new System.Drawing.Point(168, 30);
            this.tbxModelCode.Name = "tbxModelCode";
            this.tbxModelCode.Size = new System.Drawing.Size(148, 22);
            this.tbxModelCode.TabIndex = 4;
            // 
            // cbxModelType
            // 
            this.cbxModelType.DataSource = this.tbModuleTypeBindingSource1;
            this.cbxModelType.DisplayMember = "ModuleTypeName";
            this.cbxModelType.FormattingEnabled = true;
            this.cbxModelType.Location = new System.Drawing.Point(168, 140);
            this.cbxModelType.Name = "cbxModelType";
            this.cbxModelType.Size = new System.Drawing.Size(148, 24);
            this.cbxModelType.TabIndex = 12;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(57, 270);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(26, 23);
            this.btnPrev.TabIndex = 20;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbModuleTypeBindingSource1
            // 
            this.tbModuleTypeBindingSource1.DataMember = "tb_ModuleType";
            this.tbModuleTypeBindingSource1.DataSource = this.universityDataSet;
            // 
            // tbxFilter
            // 
            this.tbxFilter.HideSelection = false;
            this.tbxFilter.Location = new System.Drawing.Point(12, 45);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(140, 22);
            this.tbxFilter.TabIndex = 21;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 450);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(moduleCodeLabel);
            this.Controls.Add(this.moduleCodeTextBox);
            this.Controls.Add(moduleNameLabel);
            this.Controls.Add(this.moduleNameTextBox);
            this.Controls.Add(moduleYearLabel);
            this.Controls.Add(this.moduleYearTextBox);
            this.Controls.Add(moduleTypeLabel);
            this.Controls.Add(this.tb_ModuleBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ModuleBindingNavigator)).EndInit();
            this.tb_ModuleBindingNavigator.ResumeLayout(false);
            this.tb_ModuleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbModuleTypeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UniversityDataSet universityDataSet;
        private System.Windows.Forms.BindingSource tb_ModuleBindingSource;
        private UniversityDataSetTableAdapters.tb_ModuleTableAdapter tb_ModuleTableAdapter;
        private UniversityDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ModuleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_ModuleBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox moduleCodeTextBox;
        private System.Windows.Forms.TextBox moduleNameTextBox;
        private System.Windows.Forms.TextBox moduleYearTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private UniversityDataSetTableAdapters.tb_ModuleTypeTableAdapter tb_ModuleTypeTableAdapter;
        private System.Windows.Forms.BindingSource universityDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbModuleTypeBindingSource;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxModelName;
        private System.Windows.Forms.TextBox tbxModelYear;
        private System.Windows.Forms.TextBox tbxModelCode;
        private System.Windows.Forms.ComboBox cbxModelType;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource tbModuleTypeBindingSource1;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

