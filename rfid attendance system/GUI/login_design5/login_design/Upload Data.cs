using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_design
{
    public partial class Upload_Data : Form
    {
        public Upload_Data()
        {
            InitializeComponent();
            rfid_CardTextBox.Enabled = false;
            serialPort1.Open();
            
        }
        private void tableBindingNavigatorSaveItem_Click(object sender,

EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

      
        private void Upload_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.studentDataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.Jpg)|*.Jpg| PNG Files (*.Png)|*.Png| All Files(*.*)|*.*";
            dlg.Title = "Upload Picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                String picPath = dlg.FileName.ToString();
                photoPictureBox.ImageLocation = picPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Hide();
            Upload u = new Upload();
            u.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableBindingSource.AddNew();
                MessageBox.Show("You can add new field now");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",

MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.studentDataSet);
                MessageBox.Show("Your data has been saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",

MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            rfid_CardTextBox.Text = serialPort1.ReadLine();
        }


       

       
    }
}
