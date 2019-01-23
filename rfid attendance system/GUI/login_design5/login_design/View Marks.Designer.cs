namespace login_design
{
    partial class View_Marks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Marks));
            this.studentDataSet1 = new login_design.StudentDataSet1();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksTableAdapter = new login_design.StudentDataSet1TableAdapters.MarksTableAdapter();
            this.tableAdapterManager = new login_design.StudentDataSet1TableAdapters.TableAdapterManager();
            this.marksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.marksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.marksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.fillBy3ToolStrip = new System.Windows.Forms.ToolStrip();
            this.classToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.classToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingNavigator)).BeginInit();
            this.marksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).BeginInit();
            this.fillBy3ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "Marks";
            this.marksBindingSource.DataSource = this.studentDataSet1;
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FeeTableAdapter = null;
            this.tableAdapterManager.MarksTableAdapter = this.marksTableAdapter;
            this.tableAdapterManager.UpdateOrder = login_design.StudentDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // marksBindingNavigator
            // 
            this.marksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.marksBindingNavigator.BindingSource = this.marksBindingSource;
            this.marksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.marksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.marksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.marksBindingNavigatorSaveItem});
            this.marksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.marksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.marksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.marksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.marksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.marksBindingNavigator.Name = "marksBindingNavigator";
            this.marksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.marksBindingNavigator.Size = new System.Drawing.Size(1174, 25);
            this.marksBindingNavigator.TabIndex = 0;
            this.marksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // marksBindingNavigatorSaveItem
            // 
            this.marksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.marksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("marksBindingNavigatorSaveItem.Image")));
            this.marksBindingNavigatorSaveItem.Name = "marksBindingNavigatorSaveItem";
            this.marksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.marksBindingNavigatorSaveItem.Text = "Save Data";
            this.marksBindingNavigatorSaveItem.Click += new System.EventHandler(this.marksBindingNavigatorSaveItem_Click);
            // 
            // marksDataGridView
            // 
            this.marksDataGridView.AllowUserToAddRows = false;
            this.marksDataGridView.AllowUserToDeleteRows = false;
            this.marksDataGridView.AutoGenerateColumns = false;
            this.marksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.marksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.marksDataGridView.DataSource = this.marksBindingSource;
            this.marksDataGridView.Location = new System.Drawing.Point(12, 75);
            this.marksDataGridView.Name = "marksDataGridView";
            this.marksDataGridView.ReadOnly = true;
            this.marksDataGridView.Size = new System.Drawing.Size(1142, 220);
            this.marksDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Father Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Father Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Roll No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Roll No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn17.HeaderText = "Class";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Test 1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Test 1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Test 2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Test 2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 50;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Test 3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Test 3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 50;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Test 4";
            this.dataGridViewTextBoxColumn8.HeaderText = "Test 4";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Test 5";
            this.dataGridViewTextBoxColumn9.HeaderText = "Test 5";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 50;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Test 6";
            this.dataGridViewTextBoxColumn10.HeaderText = "Test 6";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 50;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Test 7";
            this.dataGridViewTextBoxColumn11.HeaderText = "Test 7";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 50;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Test 8";
            this.dataGridViewTextBoxColumn12.HeaderText = "Test 8";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 50;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Test 9";
            this.dataGridViewTextBoxColumn13.HeaderText = "Test 9";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 50;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Test 10";
            this.dataGridViewTextBoxColumn14.HeaderText = "Test 10";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Test 11";
            this.dataGridViewTextBoxColumn15.HeaderText = "Test 11";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 50;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Test 12";
            this.dataGridViewTextBoxColumn16.HeaderText = "Test 12";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 50;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1079, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fillBy3ToolStrip
            // 
            this.fillBy3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripLabel,
            this.classToolStripTextBox,
            this.fillBy3ToolStripButton});
            this.fillBy3ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillBy3ToolStrip.Name = "fillBy3ToolStrip";
            this.fillBy3ToolStrip.Size = new System.Drawing.Size(1174, 25);
            this.fillBy3ToolStrip.TabIndex = 3;
            this.fillBy3ToolStrip.Text = "fillBy3ToolStrip";
            // 
            // classToolStripLabel
            // 
            this.classToolStripLabel.Name = "classToolStripLabel";
            this.classToolStripLabel.Size = new System.Drawing.Size(37, 22);
            this.classToolStripLabel.Text = "Class:";
            // 
            // classToolStripTextBox
            // 
            this.classToolStripTextBox.Name = "classToolStripTextBox";
            this.classToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy3ToolStripButton
            // 
            this.fillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy3ToolStripButton.Name = "fillBy3ToolStripButton";
            this.fillBy3ToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillBy3ToolStripButton.Text = "Search";
            this.fillBy3ToolStripButton.Click += new System.EventHandler(this.fillBy3ToolStripButton_Click);
            // 
            // View_Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 354);
            this.Controls.Add(this.fillBy3ToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.marksDataGridView);
            this.Controls.Add(this.marksBindingNavigator);
            this.Name = "View_Marks";
            this.Text = "View_Marks";
            this.Load += new System.EventHandler(this.View_Marks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingNavigator)).EndInit();
            this.marksBindingNavigator.ResumeLayout(false);
            this.marksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksDataGridView)).EndInit();
            this.fillBy3ToolStrip.ResumeLayout(false);
            this.fillBy3ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private StudentDataSet1TableAdapters.MarksTableAdapter marksTableAdapter;
        private StudentDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator marksBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton marksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView marksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip fillBy3ToolStrip;
        private System.Windows.Forms.ToolStripLabel classToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox classToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy3ToolStripButton;
    }
}