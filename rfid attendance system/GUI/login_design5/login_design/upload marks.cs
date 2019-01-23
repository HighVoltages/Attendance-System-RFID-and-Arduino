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
    public partial class upload_marks : Form
    {
        public upload_marks()
        {
            InitializeComponent();
        }

        private void marksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet1);

        }

        private void upload_marks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.Marks' table. You can move, or remove it, as needed.
            this.marksTableAdapter.Fill(this.studentDataSet1.Marks);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marksTableAdapter.FillBy1(this.studentDataSet1.Marks, rollToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marksTableAdapter.FillBy2(this.studentDataSet1.Marks, _classToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload up = new Upload();
            up.Show();
        }
    }
}
 