using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace login_design
{
    public partial class Assignment : Form
    {
        public Assignment()
        {
            InitializeComponent();
            serialPort1.Open();
        }




      
      

      

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String abc = phoneTextBox.Text.ToString();
                serialPort1.Write(abc);
                MessageBox.Show("Message Send");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Assignment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.studentDataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload u = new Upload();
            u.Show();
            serialPort1.Close();
        }

        private void fillBy9ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy9(this.studentDataSet.Table, rollToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        }

       

      
    }

