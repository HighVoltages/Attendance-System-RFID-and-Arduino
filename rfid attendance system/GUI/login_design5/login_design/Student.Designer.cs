namespace login_design
{
    partial class Student
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label f_NameLabel;
            System.Windows.Forms.Label roll_No_Label;
            System.Windows.Forms.Label batchLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label rfid_CardLabel;
            System.Windows.Forms.Label phoneLabel;
            this.studentDataSet = new login_design.StudentDataSet();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableAdapter = new login_design.StudentDataSetTableAdapters.AttendanceTableAdapter();
            this.tableAdapterManager = new login_design.StudentDataSetTableAdapters.TableAdapterManager();
            this.rfid_CardTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new login_design.StudentDataSetTableAdapters.TableTableAdapter();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.roll_NoToolStrip = new System.Windows.Forms.ToolStrip();
            this.rfid_cardToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.roll_NoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.timetable = new login_design.timetable();
            this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeTableTableAdapter = new login_design.timetableTableAdapters.TimeTableTableAdapter();
            this.tableAdapterManager1 = new login_design.timetableTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.f_NameTextBox = new System.Windows.Forms.TextBox();
            this.roll_No_TextBox = new System.Windows.Forms.TextBox();
            this.batchTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.sectionTextBox = new System.Windows.Forms.TextBox();
            this.rfid_CardTextBox1 = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.fillBy8ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy8ToolStripButton = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            f_NameLabel = new System.Windows.Forms.Label();
            roll_No_Label = new System.Windows.Forms.Label();
            batchLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            rfid_CardLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.roll_NoToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
            this.fillBy8ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.ForeColor = System.Drawing.Color.OrangeRed;
            idLabel.Location = new System.Drawing.Point(558, 101);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 10;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            nameLabel.Location = new System.Drawing.Point(558, 127);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 12;
            nameLabel.Text = "Name:";
            // 
            // f_NameLabel
            // 
            f_NameLabel.AutoSize = true;
            f_NameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            f_NameLabel.Location = new System.Drawing.Point(558, 153);
            f_NameLabel.Name = "f_NameLabel";
            f_NameLabel.Size = new System.Drawing.Size(47, 13);
            f_NameLabel.TabIndex = 14;
            f_NameLabel.Text = "F Name:";
            // 
            // roll_No_Label
            // 
            roll_No_Label.AutoSize = true;
            roll_No_Label.ForeColor = System.Drawing.Color.OrangeRed;
            roll_No_Label.Location = new System.Drawing.Point(558, 179);
            roll_No_Label.Name = "roll_No_Label";
            roll_No_Label.Size = new System.Drawing.Size(48, 13);
            roll_No_Label.TabIndex = 16;
            roll_No_Label.Text = "Roll No :";
            // 
            // batchLabel
            // 
            batchLabel.AutoSize = true;
            batchLabel.ForeColor = System.Drawing.Color.OrangeRed;
            batchLabel.Location = new System.Drawing.Point(558, 205);
            batchLabel.Name = "batchLabel";
            batchLabel.Size = new System.Drawing.Size(38, 13);
            batchLabel.TabIndex = 18;
            batchLabel.Text = "Batch:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.ForeColor = System.Drawing.Color.OrangeRed;
            departmentLabel.Location = new System.Drawing.Point(558, 231);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 20;
            departmentLabel.Text = "Department:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.ForeColor = System.Drawing.Color.OrangeRed;
            sectionLabel.Location = new System.Drawing.Point(558, 257);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(46, 13);
            sectionLabel.TabIndex = 22;
            sectionLabel.Text = "Section:";
            // 
            // rfid_CardLabel
            // 
            rfid_CardLabel.AutoSize = true;
            rfid_CardLabel.ForeColor = System.Drawing.Color.OrangeRed;
            rfid_CardLabel.Location = new System.Drawing.Point(558, 283);
            rfid_CardLabel.Name = "rfid_CardLabel";
            rfid_CardLabel.Size = new System.Drawing.Size(54, 13);
            rfid_CardLabel.TabIndex = 24;
            rfid_CardLabel.Text = "Rfid Card:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.ForeColor = System.Drawing.Color.OrangeRed;
            phoneLabel.Location = new System.Drawing.Point(558, 319);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 30;
            phoneLabel.Text = "Phone:";
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
            // rfid_CardTextBox
            // 
            this.rfid_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Rfid Card", true));
            this.rfid_CardTextBox.Location = new System.Drawing.Point(233, 127);
            this.rfid_CardTextBox.Name = "rfid_CardTextBox";
            this.rfid_CardTextBox.Size = new System.Drawing.Size(10, 20);
            this.rfid_CardTextBox.TabIndex = 4;
            // 
            // dateTextBox
            // 
            this.dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attendanceBindingSource, "Date", true));
            this.dateTextBox.Location = new System.Drawing.Point(233, 153);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(10, 20);
            this.dateTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM5";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.Color.White;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(223, 110);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(109, 134);
            this.photoPictureBox.TabIndex = 9;
            this.photoPictureBox.TabStop = false;
            // 
            // roll_NoToolStrip
            // 
            this.roll_NoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rfid_cardToolStripTextBox,
            this.roll_NoToolStripButton});
            this.roll_NoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.roll_NoToolStrip.Name = "roll_NoToolStrip";
            this.roll_NoToolStrip.Size = new System.Drawing.Size(1354, 25);
            this.roll_NoToolStrip.TabIndex = 10;
            this.roll_NoToolStrip.Text = "roll_NoToolStrip";
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
            this.roll_NoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.roll_NoToolStripButton.Text = ".";
            this.roll_NoToolStripButton.Click += new System.EventHandler(this.roll_NoToolStripButton_Click);
            // 
            // timetable
            // 
            this.timetable.DataSetName = "timetable";
            this.timetable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timeTableBindingSource
            // 
            this.timeTableBindingSource.DataMember = "TimeTable";
            this.timeTableBindingSource.DataSource = this.timetable;
            // 
            // timeTableTableAdapter
            // 
            this.timeTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AttendanceTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TableTableAdapter = null;
            this.tableAdapterManager1.TimeTableTableAdapter = this.timeTableTableAdapter;
            this.tableAdapterManager1.UpdateOrder = login_design.timetableTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(629, 98);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 11;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(629, 124);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 13;
            // 
            // f_NameTextBox
            // 
            this.f_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "F_Name", true));
            this.f_NameTextBox.Location = new System.Drawing.Point(629, 150);
            this.f_NameTextBox.Name = "f_NameTextBox";
            this.f_NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.f_NameTextBox.TabIndex = 15;
            // 
            // roll_No_TextBox
            // 
            this.roll_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Roll No_", true));
            this.roll_No_TextBox.Location = new System.Drawing.Point(629, 176);
            this.roll_No_TextBox.Name = "roll_No_TextBox";
            this.roll_No_TextBox.Size = new System.Drawing.Size(100, 20);
            this.roll_No_TextBox.TabIndex = 17;
            // 
            // batchTextBox
            // 
            this.batchTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Batch", true));
            this.batchTextBox.Location = new System.Drawing.Point(629, 202);
            this.batchTextBox.Name = "batchTextBox";
            this.batchTextBox.Size = new System.Drawing.Size(100, 20);
            this.batchTextBox.TabIndex = 19;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(629, 228);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.departmentTextBox.TabIndex = 21;
            // 
            // sectionTextBox
            // 
            this.sectionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Section", true));
            this.sectionTextBox.Location = new System.Drawing.Point(629, 254);
            this.sectionTextBox.Name = "sectionTextBox";
            this.sectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.sectionTextBox.TabIndex = 23;
            // 
            // rfid_CardTextBox1
            // 
            this.rfid_CardTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Rfid Card", true));
            this.rfid_CardTextBox1.Location = new System.Drawing.Point(629, 280);
            this.rfid_CardTextBox1.Name = "rfid_CardTextBox1";
            this.rfid_CardTextBox1.Size = new System.Drawing.Size(100, 20);
            this.rfid_CardTextBox1.TabIndex = 25;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(629, 316);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 31;
            // 
            // fillBy8ToolStrip
            // 
            this.fillBy8ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy8ToolStripButton});
            this.fillBy8ToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillBy8ToolStrip.Name = "fillBy8ToolStrip";
            this.fillBy8ToolStrip.Size = new System.Drawing.Size(1354, 25);
            this.fillBy8ToolStrip.TabIndex = 32;
            this.fillBy8ToolStrip.Text = "fillBy8ToolStrip";
            // 
            // fillBy8ToolStripButton
            // 
            this.fillBy8ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy8ToolStripButton.Name = "fillBy8ToolStripButton";
            this.fillBy8ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy8ToolStripButton.Text = "FillBy8";
            this.fillBy8ToolStripButton.Click += new System.EventHandler(this.fillBy8ToolStripButton_Click_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1354, 448);
            this.Controls.Add(this.fillBy8ToolStrip);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(f_NameLabel);
            this.Controls.Add(this.f_NameTextBox);
            this.Controls.Add(roll_No_Label);
            this.Controls.Add(this.roll_No_TextBox);
            this.Controls.Add(batchLabel);
            this.Controls.Add(this.batchTextBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.sectionTextBox);
            this.Controls.Add(rfid_CardLabel);
            this.Controls.Add(this.rfid_CardTextBox1);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.roll_NoToolStrip);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rfid_CardTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.roll_NoToolStrip.ResumeLayout(false);
            this.roll_NoToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
            this.fillBy8ToolStrip.ResumeLayout(false);
            this.fillBy8ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private StudentDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox rfid_CardTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private StudentDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ToolStrip roll_NoToolStrip;
        private System.Windows.Forms.ToolStripTextBox rfid_cardToolStripTextBox;
        private System.Windows.Forms.ToolStripButton roll_NoToolStripButton;
        private timetable timetable;
        private System.Windows.Forms.BindingSource timeTableBindingSource;
        private timetableTableAdapters.TimeTableTableAdapter timeTableTableAdapter;
        private timetableTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox f_NameTextBox;
        private System.Windows.Forms.TextBox roll_No_TextBox;
        private System.Windows.Forms.TextBox batchTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox sectionTextBox;
        private System.Windows.Forms.TextBox rfid_CardTextBox1;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.ToolStrip fillBy8ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy8ToolStripButton;
    }
}