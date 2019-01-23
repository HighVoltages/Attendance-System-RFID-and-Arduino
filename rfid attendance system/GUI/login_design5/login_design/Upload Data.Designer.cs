namespace login_design
{
    partial class Upload_Data
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label f_NameLabel;
            System.Windows.Forms.Label batchLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label sectionLabel;
            System.Windows.Forms.Label rfid_CardLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label roll_No_Label;
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new login_design.StudentDataSet();
            this.tableTableAdapter = new login_design.StudentDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new login_design.StudentDataSetTableAdapters.TableAdapterManager();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.f_NameTextBox = new System.Windows.Forms.TextBox();
            this.batchComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.rfid_CardTextBox = new System.Windows.Forms.TextBox();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.roll_No_TextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            f_NameLabel = new System.Windows.Forms.Label();
            batchLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            sectionLabel = new System.Windows.Forms.Label();
            rfid_CardLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            roll_No_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "Name:";
            // 
            // f_NameLabel
            // 
            f_NameLabel.AutoSize = true;
            f_NameLabel.Location = new System.Drawing.Point(12, 83);
            f_NameLabel.Name = "f_NameLabel";
            f_NameLabel.Size = new System.Drawing.Size(47, 13);
            f_NameLabel.TabIndex = 4;
            f_NameLabel.Text = "F Name:";
            // 
            // batchLabel
            // 
            batchLabel.AutoSize = true;
            batchLabel.Location = new System.Drawing.Point(12, 111);
            batchLabel.Name = "batchLabel";
            batchLabel.Size = new System.Drawing.Size(38, 13);
            batchLabel.TabIndex = 8;
            batchLabel.Text = "Batch:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(12, 138);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 10;
            departmentLabel.Text = "Department:";
            // 
            // sectionLabel
            // 
            sectionLabel.AutoSize = true;
            sectionLabel.Location = new System.Drawing.Point(12, 165);
            sectionLabel.Name = "sectionLabel";
            sectionLabel.Size = new System.Drawing.Size(46, 13);
            sectionLabel.TabIndex = 12;
            sectionLabel.Text = "Section:";
            // 
            // rfid_CardLabel
            // 
            rfid_CardLabel.AutoSize = true;
            rfid_CardLabel.Location = new System.Drawing.Point(12, 192);
            rfid_CardLabel.Name = "rfid_CardLabel";
            rfid_CardLabel.Size = new System.Drawing.Size(29, 13);
            rfid_CardLabel.TabIndex = 14;
            rfid_CardLabel.Text = "RFid";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(12, 218);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 20;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 244);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 22;
            emailLabel.Text = "Email:";
            // 
            // roll_No_Label
            // 
            roll_No_Label.AutoSize = true;
            roll_No_Label.Location = new System.Drawing.Point(11, 273);
            roll_No_Label.Name = "roll_No_Label";
            roll_No_Label.Size = new System.Drawing.Size(48, 13);
            roll_No_Label.TabIndex = 28;
            roll_No_Label.Text = "Roll No :";
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
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(83, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // f_NameTextBox
            // 
            this.f_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "F_Name", true));
            this.f_NameTextBox.Location = new System.Drawing.Point(83, 80);
            this.f_NameTextBox.Name = "f_NameTextBox";
            this.f_NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.f_NameTextBox.TabIndex = 5;
            // 
            // batchComboBox
            // 
            this.batchComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Batch", true));
            this.batchComboBox.FormattingEnabled = true;
            this.batchComboBox.Items.AddRange(new object[] {
            "2015"});
            this.batchComboBox.Location = new System.Drawing.Point(83, 108);
            this.batchComboBox.Name = "batchComboBox";
            this.batchComboBox.Size = new System.Drawing.Size(121, 21);
            this.batchComboBox.TabIndex = 9;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Department", true));
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "EE"});
            this.departmentComboBox.Location = new System.Drawing.Point(83, 135);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 21);
            this.departmentComboBox.TabIndex = 11;
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Section", true));
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Items.AddRange(new object[] {
            "C"});
            this.sectionComboBox.Location = new System.Drawing.Point(83, 162);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sectionComboBox.TabIndex = 13;
            // 
            // rfid_CardTextBox
            // 
            this.rfid_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Rfid Card", true));
            this.rfid_CardTextBox.Location = new System.Drawing.Point(83, 189);
            this.rfid_CardTextBox.Name = "rfid_CardTextBox";
            this.rfid_CardTextBox.Size = new System.Drawing.Size(121, 20);
            this.rfid_CardTextBox.TabIndex = 15;
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.photoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "Photo", true));
            this.photoPictureBox.Location = new System.Drawing.Point(305, 108);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(102, 127);
            this.photoPictureBox.TabIndex = 19;
            this.photoPictureBox.TabStop = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(83, 215);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(121, 20);
            this.phoneTextBox.TabIndex = 21;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(83, 241);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(121, 20);
            this.emailTextBox.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 24;
            this.button1.Text = "Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 25;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 26;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(288, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 27;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(83, 316);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 38);
            this.button5.TabIndex = 28;
            this.button5.Text = "Get Rfid";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // roll_No_TextBox
            // 
            this.roll_No_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Roll No_", true));
            this.roll_No_TextBox.Location = new System.Drawing.Point(83, 270);
            this.roll_No_TextBox.Name = "roll_No_TextBox";
            this.roll_No_TextBox.Size = new System.Drawing.Size(121, 20);
            this.roll_No_TextBox.TabIndex = 29;
            // 
            // Upload_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(569, 459);
            this.Controls.Add(roll_No_Label);
            this.Controls.Add(this.roll_No_TextBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(f_NameLabel);
            this.Controls.Add(this.f_NameTextBox);
            this.Controls.Add(batchLabel);
            this.Controls.Add(this.batchComboBox);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(sectionLabel);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(rfid_CardLabel);
            this.Controls.Add(this.rfid_CardTextBox);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Upload_Data";
            this.Text = "Upload Data";
            this.Load += new System.EventHandler(this.Upload_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private StudentDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private StudentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox f_NameTextBox;
        private System.Windows.Forms.ComboBox batchComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.TextBox rfid_CardTextBox;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox roll_No_TextBox;
    }
}