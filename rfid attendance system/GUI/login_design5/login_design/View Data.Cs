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
    public partial class View_Data : Form
    {
        public View_Data()
        {
            InitializeComponent();
            
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void View_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.studentDataSet.Table);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View v = new View();
            v.Show();
        }

        private void roll_NoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Roll_No(this.studentDataSet.Table, rfid_cardToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            View v = new View();
            v.Show();
        }

        private void rOLL_NO2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.ROLL_NO2(this.studentDataSet.Table, roll_NoToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      

        

      

    }
}
