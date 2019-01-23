namespace login_design
{
    partial class View_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Data));
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new login_design.StudentDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roll_NoToolStrip = new System.Windows.Forms.ToolStrip();
            this.rfid_cardToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rfid_cardToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.roll_NoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rOLL_NO2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.roll_NoToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.roll_NoToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.rOLL_NO2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tableTableAdapter = new login_design.StudentDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new login_design.StudentDataSetTableAdapters.TableAdapterManager();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.roll_NoToolStrip.SuspendLayout();
            this.rOLL_NO2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = null;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = null;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.tableBindingNavigatorSaveItem});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.PositionItem = null;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1094, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tableBindingNavigatorSaveItem.Text = "Save Data";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToAddRows = false;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(51, 82);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.Size = new System.Drawing.Size(1023, 220);
            this.tableDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "F_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "F_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Roll No_";
            this.dataGridViewTextBoxColumn1.HeaderText = "Roll No_";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Batch";
            this.dataGridViewTextBoxColumn5.HeaderText = "Batch";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Department";
            this.dataGridViewTextBoxColumn6.HeaderText = "Department";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Section";
            this.dataGridViewTextBoxColumn7.HeaderText = "Section";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Rfid Card";
            this.dataGridViewTextBoxColumn9.HeaderText = "Rfid Card";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Photo";
            this.dataGridViewImageColumn1.HeaderText = "Photo";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn11.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn12.HeaderText = "Email";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // roll_NoToolStrip
            // 
            this.roll_NoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rfid_cardToolStripLabel,
            this.rfid_cardToolStripTextBox,
            this.roll_NoToolStripButton});
            this.roll_NoToolStrip.Location = new System.Drawing.Point(0, 25);
            this.roll_NoToolStrip.Name = "roll_NoToolStrip";
            this.roll_NoToolStrip.Size = new System.Drawing.Size(1094, 25);
            this.roll_NoToolStrip.TabIndex = 3;
            this.roll_NoToolStrip.Text = "roll_NoToolStrip";
            // 
            // rfid_cardToolStripLabel
            // 
            this.rfid_cardToolStripLabel.Name = "rfid_cardToolStripLabel";
            this.rfid_cardToolStripLabel.Size = new System.Drawing.Size(31, 22);
            this.rfid_cardToolStripLabel.Text = "RFID";
            // 
            // rfid_cardToolStripTextBox
            // 
            this.rfid_cardToolStripTextBox.Name = "rfid_cardToolStripTextBox";
            this.rfid_cardToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // roll_NoToolStripButton
            // 
            this.roll_NoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.roll_NoToolStripButton.Name = "roll_NoToolStripButton";
            this.roll_NoToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.roll_NoToolStripButton.Text = "Search";
            this.roll_NoToolStripButton.Click += new System.EventHandler(this.roll_NoToolStripButton_Click);
            // 
            // rOLL_NO2ToolStrip
            // 
            this.rOLL_NO2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roll_NoToolStripLabel,
            this.roll_NoToolStripTextBox,
            this.rOLL_NO2ToolStripButton});
            this.rOLL_NO2ToolStrip.Location = new System.Drawing.Point(0, 50);
            this.rOLL_NO2ToolStrip.Name = "rOLL_NO2ToolStrip";
            this.rOLL_NO2ToolStrip.Size = new System.Drawing.Size(1094, 25);
            this.rOLL_NO2ToolStrip.TabIndex = 5;
            this.rOLL_NO2ToolStrip.Text = "rOLL_NO2ToolStrip";
            // 
            // roll_NoToolStripLabel
            // 
            this.roll_NoToolStripLabel.Name = "roll_NoToolStripLabel";
            this.roll_NoToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.roll_NoToolStripLabel.Text = "Roll No:";
            // 
            // roll_NoToolStripTextBox
            // 
            this.roll_NoToolStripTextBox.Name = "roll_NoToolStripTextBox";
            this.roll_NoToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // rOLL_NO2ToolStripButton
            // 
            this.rOLL_NO2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rOLL_NO2ToolStripButton.Name = "rOLL_NO2ToolStripButton";
            this.rOLL_NO2ToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.rOLL_NO2ToolStripButton.Text = "Search";
            this.rOLL_NO2ToolStripButton.Click += new System.EventHandler(this.rOLL_NO2ToolStripButton_Click);
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AttendanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = login_design.StudentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // View_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 362);
            this.Controls.Add(this.rOLL_NO2ToolStrip);
            this.Controls.Add(this.roll_NoToolStrip);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "View_Data";
            this.Text = "View Data";
            this.Load += new System.EventHandler(this.View_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.roll_NoToolStrip.ResumeLayout(false);
            this.roll_NoToolStrip.PerformLayout();
            this.rOLL_NO2ToolStrip.ResumeLayout(false);
            this.rOLL_NO2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private StudentDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.ToolStrip roll_NoToolStrip;
        private System.Windows.Forms.ToolStripLabel rfid_cardToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rfid_cardToolStripTextBox;
        private System.Windows.Forms.ToolStripButton roll_NoToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStrip rOLL_NO2ToolStrip;
        private System.Windows.Forms.ToolStripLabel roll_NoToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox roll_NoToolStripTextBox;
        private System.Windows.Forms.ToolStripButton rOLL_NO2ToolStripButton;
        private System.IO.Ports.SerialPort serialPort1;
    }
}