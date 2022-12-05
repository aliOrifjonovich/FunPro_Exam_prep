namespace Childrens
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
            System.Windows.Forms.Label childName_1461Label;
            System.Windows.Forms.Label childAddress_1461Label;
            System.Windows.Forms.Label childBirthDate_1461Label;
            System.Windows.Forms.Label childWeight_1461Label;
            System.Windows.Forms.Label childCategory_1461Label;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.childrenDataSet = new Childrens.ChildrenDataSet();
            this.tb_ChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ChildTableAdapter = new Childrens.ChildrenDataSetTableAdapters.tb_ChildTableAdapter();
            this.tableAdapterManager = new Childrens.ChildrenDataSetTableAdapters.TableAdapterManager();
            this.tb_ChildCategoryTableAdapter = new Childrens.ChildrenDataSetTableAdapters.tb_ChildCategoryTableAdapter();
            this.tb_ChildBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_ChildBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.childName_1461TextBox = new System.Windows.Forms.TextBox();
            this.childAddress_1461TextBox = new System.Windows.Forms.TextBox();
            this.childBirthDate_1461DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbChildCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxChildAddress = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbChildCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbxChildName = new System.Windows.Forms.TextBox();
            this.tbChildBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.tbChildBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbxFilter = new System.Windows.Forms.TextBox();
            childName_1461Label = new System.Windows.Forms.Label();
            childAddress_1461Label = new System.Windows.Forms.Label();
            childBirthDate_1461Label = new System.Windows.Forms.Label();
            childWeight_1461Label = new System.Windows.Forms.Label();
            childCategory_1461Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingNavigator)).BeginInit();
            this.tb_ChildBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // childName_1461Label
            // 
            childName_1461Label.AutoSize = true;
            childName_1461Label.Location = new System.Drawing.Point(227, 82);
            childName_1461Label.Name = "childName_1461Label";
            childName_1461Label.Size = new System.Drawing.Size(111, 16);
            childName_1461Label.TabIndex = 3;
            childName_1461Label.Text = "Child Name 1461:";
            // 
            // childAddress_1461Label
            // 
            childAddress_1461Label.AutoSize = true;
            childAddress_1461Label.Location = new System.Drawing.Point(227, 127);
            childAddress_1461Label.Name = "childAddress_1461Label";
            childAddress_1461Label.Size = new System.Drawing.Size(125, 16);
            childAddress_1461Label.TabIndex = 5;
            childAddress_1461Label.Text = "Child Address 1461:";
            // 
            // childBirthDate_1461Label
            // 
            childBirthDate_1461Label.AutoSize = true;
            childBirthDate_1461Label.Location = new System.Drawing.Point(227, 165);
            childBirthDate_1461Label.Name = "childBirthDate_1461Label";
            childBirthDate_1461Label.Size = new System.Drawing.Size(132, 16);
            childBirthDate_1461Label.TabIndex = 7;
            childBirthDate_1461Label.Text = "Child Birth Date 1461:";
            // 
            // childWeight_1461Label
            // 
            childWeight_1461Label.AutoSize = true;
            childWeight_1461Label.Location = new System.Drawing.Point(227, 202);
            childWeight_1461Label.Name = "childWeight_1461Label";
            childWeight_1461Label.Size = new System.Drawing.Size(116, 16);
            childWeight_1461Label.TabIndex = 9;
            childWeight_1461Label.Text = "Child Weight 1461:";
            // 
            // childCategory_1461Label
            // 
            childCategory_1461Label.AutoSize = true;
            childCategory_1461Label.Location = new System.Drawing.Point(227, 244);
            childCategory_1461Label.Name = "childCategory_1461Label";
            childCategory_1461Label.Size = new System.Drawing.Size(129, 16);
            childCategory_1461Label.TabIndex = 11;
            childCategory_1461Label.Text = "Child Category 1461:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(43, 198);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(129, 16);
            label1.TabIndex = 11;
            label1.Text = "Child Category 1461:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(43, 156);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 16);
            label2.TabIndex = 9;
            label2.Text = "Child Weight 1461:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(43, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 16);
            label3.TabIndex = 7;
            label3.Text = "Child Birth Date 1461:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(43, 81);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(125, 16);
            label4.TabIndex = 5;
            label4.Text = "Child Address 1461:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(43, 36);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(111, 16);
            label5.TabIndex = 3;
            label5.Text = "Child Name 1461:";
            // 
            // childrenDataSet
            // 
            this.childrenDataSet.DataSetName = "ChildrenDataSet";
            this.childrenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_ChildBindingSource
            // 
            this.tb_ChildBindingSource.DataMember = "tb_Child";
            this.tb_ChildBindingSource.DataSource = this.childrenDataSet;
            this.tb_ChildBindingSource.CurrentChanged += new System.EventHandler(this.tb_ChildBindingSource_CurrentChanged);
            // 
            // tb_ChildTableAdapter
            // 
            this.tb_ChildTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ChildCategoryTableAdapter = this.tb_ChildCategoryTableAdapter;
            this.tableAdapterManager.tb_ChildTableAdapter = this.tb_ChildTableAdapter;
            this.tableAdapterManager.UpdateOrder = Childrens.ChildrenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_ChildCategoryTableAdapter
            // 
            this.tb_ChildCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tb_ChildBindingNavigator
            // 
            this.tb_ChildBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ChildBindingNavigator.BindingSource = this.tb_ChildBindingSource;
            this.tb_ChildBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ChildBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ChildBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tb_ChildBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_ChildBindingNavigatorSaveItem});
            this.tb_ChildBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ChildBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ChildBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ChildBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ChildBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ChildBindingNavigator.Name = "tb_ChildBindingNavigator";
            this.tb_ChildBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ChildBindingNavigator.Size = new System.Drawing.Size(1127, 31);
            this.tb_ChildBindingNavigator.TabIndex = 0;
            this.tb_ChildBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tb_ChildBindingNavigatorSaveItem
            // 
            this.tb_ChildBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ChildBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ChildBindingNavigatorSaveItem.Image")));
            this.tb_ChildBindingNavigatorSaveItem.Name = "tb_ChildBindingNavigatorSaveItem";
            this.tb_ChildBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.tb_ChildBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ChildBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ChildBindingNavigatorSaveItem_Click);
            // 
            // childName_1461TextBox
            // 
            this.childName_1461TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ChildBindingSource, "ChildName_1461", true));
            this.childName_1461TextBox.Location = new System.Drawing.Point(365, 79);
            this.childName_1461TextBox.Name = "childName_1461TextBox";
            this.childName_1461TextBox.Size = new System.Drawing.Size(200, 22);
            this.childName_1461TextBox.TabIndex = 4;
            // 
            // childAddress_1461TextBox
            // 
            this.childAddress_1461TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ChildBindingSource, "ChildAddress_1461", true));
            this.childAddress_1461TextBox.Location = new System.Drawing.Point(365, 124);
            this.childAddress_1461TextBox.Name = "childAddress_1461TextBox";
            this.childAddress_1461TextBox.Size = new System.Drawing.Size(200, 22);
            this.childAddress_1461TextBox.TabIndex = 6;
            // 
            // childBirthDate_1461DateTimePicker
            // 
            this.childBirthDate_1461DateTimePicker.CustomFormat = "dd/MM/yy";
            this.childBirthDate_1461DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ChildBindingSource, "ChildBirthDate_1461", true));
            this.childBirthDate_1461DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.childBirthDate_1461DateTimePicker.Location = new System.Drawing.Point(365, 165);
            this.childBirthDate_1461DateTimePicker.Name = "childBirthDate_1461DateTimePicker";
            this.childBirthDate_1461DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.childBirthDate_1461DateTimePicker.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.tb_ChildBindingSource;
            this.listBox1.DisplayMember = "ChildName_1461";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(26, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 228);
            this.listBox1.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ChildBindingSource, "ChildCategory_1461", true));
            this.comboBox1.DataSource = this.tbChildCategoryBindingSource;
            this.comboBox1.DisplayMember = "ChildCategoryName_1461";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(365, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "ID_1461";
            // 
            // tbChildCategoryBindingSource
            // 
            this.tbChildCategoryBindingSource.DataMember = "tb_ChildCategory";
            this.tbChildCategoryBindingSource.DataSource = this.childrenDataSet;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(365, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 36);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(478, 274);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(26, 304);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(43, 25);
            this.btnFirst.TabIndex = 17;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(159, 304);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(43, 25);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(75, 304);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(33, 25);
            this.btnPrev.TabIndex = 19;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(120, 304);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(33, 25);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numWeight);
            this.groupBox1.Controls.Add(this.dtpBirth);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxChildAddress);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.cbxCategory);
            this.groupBox1.Controls.Add(this.tbxChildName);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Location = new System.Drawing.Point(631, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 283);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Child";
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "dd/MM/yy";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Location = new System.Drawing.Point(181, 119);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(200, 22);
            this.dtpBirth.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(335, 36);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add New Child";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxChildAddress
            // 
            this.tbxChildAddress.Location = new System.Drawing.Point(181, 78);
            this.tbxChildAddress.Name = "tbxChildAddress";
            this.tbxChildAddress.Size = new System.Drawing.Size(200, 22);
            this.tbxChildAddress.TabIndex = 6;
            // 
            // cbxCategory
            // 
            this.cbxCategory.DataSource = this.tbChildCategoryBindingSource1;
            this.cbxCategory.DisplayMember = "ChildCategoryName_1461";
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(181, 198);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(200, 24);
            this.cbxCategory.TabIndex = 14;
            // 
            // tbChildCategoryBindingSource1
            // 
            this.tbChildCategoryBindingSource1.DataMember = "tb_ChildCategory";
            this.tbChildCategoryBindingSource1.DataSource = this.childrenDataSet;
            // 
            // tbxChildName
            // 
            this.tbxChildName.Location = new System.Drawing.Point(181, 33);
            this.tbxChildName.Name = "tbxChildName";
            this.tbxChildName.Size = new System.Drawing.Size(200, 22);
            this.tbxChildName.TabIndex = 4;
            // 
            // tbChildBindingSource
            // 
            this.tbChildBindingSource.DataMember = "tb_Child";
            this.tbChildBindingSource.DataSource = this.childrenDataSet;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_ChildBindingSource, "ChildWeight_1461", true));
            this.numericUpDown1.Location = new System.Drawing.Point(365, 200);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown1.TabIndex = 22;
            // 
            // numWeight
            // 
            this.numWeight.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbChildBindingSource1, "ChildWeight_1461", true));
            this.numWeight.Location = new System.Drawing.Point(181, 156);
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(200, 22);
            this.numWeight.TabIndex = 23;
            // 
            // tbChildBindingSource1
            // 
            this.tbChildBindingSource1.DataMember = "tb_Child";
            this.tbChildBindingSource1.DataSource = this.childrenDataSet;
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(26, 46);
            this.tbxFilter.Multiline = true;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(176, 22);
            this.tbxFilter.TabIndex = 23;
            this.tbxFilter.TextChanged += new System.EventHandler(this.tbxFilter_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(childName_1461Label);
            this.Controls.Add(this.childName_1461TextBox);
            this.Controls.Add(childAddress_1461Label);
            this.Controls.Add(this.childAddress_1461TextBox);
            this.Controls.Add(childBirthDate_1461Label);
            this.Controls.Add(this.childBirthDate_1461DateTimePicker);
            this.Controls.Add(childWeight_1461Label);
            this.Controls.Add(childCategory_1461Label);
            this.Controls.Add(this.tb_ChildBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.childrenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ChildBindingNavigator)).EndInit();
            this.tb_ChildBindingNavigator.ResumeLayout(false);
            this.tb_ChildBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildCategoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChildBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChildrenDataSet childrenDataSet;
        private System.Windows.Forms.BindingSource tb_ChildBindingSource;
        private ChildrenDataSetTableAdapters.tb_ChildTableAdapter tb_ChildTableAdapter;
        private ChildrenDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ChildBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_ChildBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox childName_1461TextBox;
        private System.Windows.Forms.TextBox childAddress_1461TextBox;
        private System.Windows.Forms.DateTimePicker childBirthDate_1461DateTimePicker;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxChildAddress;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.BindingSource tbChildBindingSource;
        private System.Windows.Forms.TextBox tbxChildName;
        private ChildrenDataSetTableAdapters.tb_ChildCategoryTableAdapter tb_ChildCategoryTableAdapter;
        private System.Windows.Forms.BindingSource tbChildCategoryBindingSource;
        private System.Windows.Forms.BindingSource tbChildCategoryBindingSource1;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.BindingSource tbChildBindingSource1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbxFilter;
    }
}

