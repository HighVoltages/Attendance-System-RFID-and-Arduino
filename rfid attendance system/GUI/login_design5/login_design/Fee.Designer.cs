namespace login_design
{
    partial class Fee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fee));
            this.studentDataSet1 = new login_design.StudentDataSet1();
            this.feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeTableAdapter = new login_design.StudentDataSet1TableAdapters.FeeTableAdapter();
            this.tableAdapterManager = new login_design.StudentDataSet1TableAdapters.TableAdapterManager();
            this.feeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.feeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.feeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn8 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn9 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn10 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn11 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.classToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.classToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingNavigator)).BeginInit();
            this.feeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feeBindingSource
            // 
            this.feeBindingSource.DataMember = "Fee";
            this.feeBindingSource.DataSource = this.studentDataSet1;
            // 
            // feeTableAdapter
            // 
            this.feeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FeeTableAdapter = this.feeTableAdapter;
            this.tableAdapterManager.MarksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = login_design.StudentDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // feeBindingNavigator
            // 
            this.feeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.feeBindingNavigator.BindingSource = this.feeBindingSource;
            this.feeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.feeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.feeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.feeBindingNavigatorSaveItem});
            this.feeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.feeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.feeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.feeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.feeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.feeBindingNavigator.Name = "feeBindingNavigator";
            this.feeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.feeBindingNavigator.Size = new System.Drawing.Size(1194, 25);
            this.feeBindingNavigator.TabIndex = 0;
            this.feeBindingNavigator.Text = "bindingNavigator1";
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
            // feeBindingNavigatorSaveItem
            // 
            this.feeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.feeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("feeBindingNavigatorSaveItem.Image")));
            this.feeBindingNavigatorSaveItem.Name = "feeBindingNavigatorSaveItem";
            this.feeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.feeBindingNavigatorSaveItem.Text = "Save Data";
            this.feeBindingNavigatorSaveItem.Click += new System.EventHandler(this.feeBindingNavigatorSaveItem_Click);
            // 
            // feeDataGridView
            // 
            this.feeDataGridView.AutoGenerateColumns = false;
            this.feeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewCheckBoxColumn7,
            this.dataGridViewCheckBoxColumn8,
            this.dataGridViewCheckBoxColumn9,
            this.dataGridViewCheckBoxColumn10,
            this.dataGridViewCheckBoxColumn11,
            this.dataGridViewCheckBoxColumn12});
            this.feeDataGridView.DataSource = this.feeBindingSource;
            this.feeDataGridView.Location = new System.Drawing.Point(0, 56);
            this.feeDataGridView.Name = "feeDataGridView";
            this.feeDataGridView.Size = new System.Drawing.Size(1143, 220);
            this.feeDataGridView.TabIndex = 1;
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Father Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Father Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Roll No";
            this.dataGridViewTextBoxColumn4.HeaderText = "Roll No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Class";
            this.dataGridViewTextBoxColumn5.HeaderText = "Class";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Jan";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Jan";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Feb";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Feb";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Width = 50;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "March";
            this.dataGridViewCheckBoxColumn3.HeaderText = "March";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Width = 50;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "April";
            this.dataGridViewCheckBoxColumn4.HeaderText = "April";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.Width = 50;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "May";
            this.dataGridViewCheckBoxColumn5.HeaderText = "May";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.Width = 50;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "June";
            this.dataGridViewCheckBoxColumn6.HeaderText = "June";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.Width = 50;
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.DataPropertyName = "July";
            this.dataGridViewCheckBoxColumn7.HeaderText = "July";
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            this.dataGridViewCheckBoxColumn7.Width = 50;
            // 
            // dataGridViewCheckBoxColumn8
            // 
            this.dataGridViewCheckBoxColumn8.DataPropertyName = "Aug";
            this.dataGridViewCheckBoxColumn8.HeaderText = "Aug";
            this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
            this.dataGridViewCheckBoxColumn8.Width = 50;
            // 
            // dataGridViewCheckBoxColumn9
            // 
            this.dataGridViewCheckBoxColumn9.DataPropertyName = "Sept";
            this.dataGridViewCheckBoxColumn9.HeaderText = "Sept";
            this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
            this.dataGridViewCheckBoxColumn9.Width = 50;
            // 
            // dataGridViewCheckBoxColumn10
            // 
            this.dataGridViewCheckBoxColumn10.DataPropertyName = "Oct";
            this.dataGridViewCheckBoxColumn10.HeaderText = "Oct";
            this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
            this.dataGridViewCheckBoxColumn10.Width = 50;
            // 
            // dataGridViewCheckBoxColumn11
            // 
            this.dataGridViewCheckBoxColumn11.DataPropertyName = "Nov";
            this.dataGridViewCheckBoxColumn11.HeaderText = "Nov";
            this.dataGridViewCheckBoxColumn11.Name = "dataGridViewCheckBoxColumn11";
            this.dataGridViewCheckBoxColumn11.Width = 50;
            // 
            // dataGridViewCheckBoxColumn12
            // 
            this.dataGridViewCheckBoxColumn12.DataPropertyName = "Dec";
            this.dataGridViewCheckBoxColumn12.HeaderText = "Dec";
            this.dataGridViewCheckBoxColumn12.Name = "dataGridViewCheckBoxColumn12";
            this.dataGridViewCheckBoxColumn12.Width = 50;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classToolStripLabel,
            this.classToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1194, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
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
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillByToolStripButton.Text = "Search";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1068, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.feeDataGridView);
            this.Controls.Add(this.feeBindingNavigator);
            this.Name = "Fee";
            this.Text = "Fee";
            this.Load += new System.EventHandler(this.Fee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingNavigator)).EndInit();
            this.feeBindingNavigator.ResumeLayout(false);
            this.feeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feeDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource feeBindingSource;
        private StudentDataSet1TableAdapters.FeeTableAdapter feeTableAdapter;
        private StudentDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator feeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton feeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView feeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel classToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox classToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}