namespace login_design
{
    partial class Assignment
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
            System.Windows.Forms.Label phoneLabel;
            this.studentDataSet_TableDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new login_design.StudentDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new login_design.StudentDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new login_design.StudentDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.fillBy9ToolStrip = new System.Windows.Forms.ToolStrip();
            this.rollToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rollToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy9ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet_TableDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.fillBy9ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(70, 78);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "Phone:";
            // 
            // studentDataSet_TableDataTableBindingSource
            // 
            this.studentDataSet_TableDataTableBindingSource.DataSource = typeof(login_design.StudentDataSet.TableDataTable);
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.studentDataSet;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(117, 75);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 15;
            // 
            // fillBy9ToolStrip
            // 
            this.fillBy9ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rollToolStripLabel,
            this.rollToolStripTextBox,
            this.fillBy9ToolStripButton});
            this.fillBy9ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy9ToolStrip.Name = "fillBy9ToolStrip";
            this.fillBy9ToolStrip.Size = new System.Drawing.Size(302, 25);
            this.fillBy9ToolStrip.TabIndex = 16;
            this.fillBy9ToolStrip.Text = "fillBy9ToolStrip";
            // 
            // rollToolStripLabel
            // 
            this.rollToolStripLabel.Name = "rollToolStripLabel";
            this.rollToolStripLabel.Size = new System.Drawing.Size(27, 22);
            this.rollToolStripLabel.Text = "roll:";
            // 
            // rollToolStripTextBox
            // 
            this.rollToolStripTextBox.Name = "rollToolStripTextBox";
            this.rollToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy9ToolStripButton
            // 
            this.fillBy9ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy9ToolStripButton.Name = "fillBy9ToolStripButton";
            this.fillBy9ToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.fillBy9ToolStripButton.Text = "Search";
            this.fillBy9ToolStripButton.Click += new System.EventHandler(this.fillBy9ToolStripButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // Assignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(302, 202);
            this.Controls.Add(this.fillBy9ToolStrip);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "Assignment";
            this.Text = "Fee Notification";
            this.Load += new System.EventHandler(this.Assignment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet_TableDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.fillBy9ToolStrip.ResumeLayout(false);
            this.fillBy9ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentDataSet_TableDataTableBindingSource;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private StudentDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ToolStrip fillBy9ToolStrip;
        private System.Windows.Forms.ToolStripLabel rollToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rollToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy9ToolStripButton;
        private System.IO.Ports.SerialPort serialPort1;
    }
}