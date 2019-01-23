namespace login_design
{
    partial class Atndnce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atndnce));
            this.studentDataSet = new login_design.StudentDataSet();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new login_design.StudentDataSetTableAdapters.AttendanceTableAdapter();
            this.tableAdapterManager = new login_design.StudentDataSetTableAdapters.TableAdapterManager();
            this.attendanceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.attendanceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attendanceDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dateToolStrip = new System.Windows.Forms.ToolStrip();
            this.dateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.dateToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingNavigator)).BeginInit();
            this.attendanceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGridView)).BeginInit();
            this.dateToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.DataSource = this.studentDataSet;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = this.attendanceTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = login_design.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attendanceBindingNavigator
            // 
            this.attendanceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attendanceBindingNavigator.BindingSource = this.attendanceBindingSource;
            this.attendanceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attendanceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attendanceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.attendanceBindingNavigatorSaveItem});
            this.attendanceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attendanceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendanceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendanceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendanceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendanceBindingNavigator.Name = "attendanceBindingNavigator";
            this.attendanceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attendanceBindingNavigator.Size = new System.Drawing.Size(488, 25);
            this.attendanceBindingNavigator.TabIndex = 0;
            this.attendanceBindingNavigator.Text = "bindingNavigator1";
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
            // attendanceBindingNavigatorSaveItem
            // 
            this.attendanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attendanceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attendanceBindingNavigatorSaveItem.Image")));
            this.attendanceBindingNavigatorSaveItem.Name = "attendanceBindingNavigatorSaveItem";
            this.attendanceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.attendanceBindingNavigatorSaveItem.Text = "Save Data";
            this.attendanceBindingNavigatorSaveItem.Click += new System.EventHandler(this.attendanceBindingNavigatorSaveItem_Click);
            // 
            // attendanceDataGridView
            // 
            this.attendanceDataGridView.AutoGenerateColumns = false;
            this.attendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.attendanceDataGridView.DataSource = this.attendanceBindingSource;
            this.attendanceDataGridView.Location = new System.Drawing.Point(23, 57);
            this.attendanceDataGridView.Name = "attendanceDataGridView";
            this.attendanceDataGridView.Size = new System.Drawing.Size(442, 220);
            this.attendanceDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateToolStrip
            // 
            this.dateToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateToolStripLabel,
            this.dateToolStripTextBox,
            this.dateToolStripButton});
            this.dateToolStrip.Location = new System.Drawing.Point(0, 25);
            this.dateToolStrip.Name = "dateToolStrip";
            this.dateToolStrip.Size = new System.Drawing.Size(488, 25);
            this.dateToolStrip.TabIndex = 3;
            this.dateToolStrip.Text = "dateToolStrip";
            // 
            // dateToolStripLabel
            // 
            this.dateToolStripLabel.Name = "dateToolStripLabel";
            this.dateToolStripLabel.Size = new System.Drawing.Size(34, 22);
            this.dateToolStripLabel.Text = "Date:";
            // 
            // dateToolStripTextBox
            // 
            this.dateToolStripTextBox.Name = "dateToolStripTextBox";
            this.dateToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // dateToolStripButton
            // 
            this.dateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.dateToolStripButton.Name = "dateToolStripButton";
            this.dateToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.dateToolStripButton.Text = "Search";
            this.dateToolStripButton.Click += new System.EventHandler(this.dateToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Present";
            this.dataGridViewTextBoxColumn4.HeaderText = "Present";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Rfid Card";
            this.dataGridViewTextBoxColumn2.HeaderText = "Rfid Card";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Atndnce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 315);
            this.Controls.Add(this.dateToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.attendanceDataGridView);
            this.Controls.Add(this.attendanceBindingNavigator);
            this.Name = "Atndnce";
            this.Text = "Atndnce";
            this.Load += new System.EventHandler(this.Atndnce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingNavigator)).EndInit();
            this.attendanceBindingNavigator.ResumeLayout(false);
            this.attendanceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataGridView)).EndInit();
            this.dateToolStrip.ResumeLayout(false);
            this.dateToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private StudentDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attendanceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton attendanceBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attendanceDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip dateToolStrip;
        private System.Windows.Forms.ToolStripLabel dateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox dateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton dateToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}