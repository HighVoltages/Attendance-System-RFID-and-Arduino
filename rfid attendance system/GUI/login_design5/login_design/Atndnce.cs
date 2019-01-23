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
    public partial class Atndnce : Form
    {
        public Atndnce()
        {
            InitializeComponent();
        }

        private void attendanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void Atndnce_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Table' table. You can move, or remove it, as needed.
           // this.tableTableAdapter.Fill(this.studentDataSet.Table);
            // TODO: This line of code loads data into the 'studentDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.studentDataSet.Attendance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View vv = new View();
            vv.Show();
        }

        private void dateToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.attendanceTableAdapter.Date(this.studentDataSet.Attendance, dateToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
