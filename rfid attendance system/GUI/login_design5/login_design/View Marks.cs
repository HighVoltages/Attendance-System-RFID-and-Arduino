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
    public partial class View_Marks : Form
    {
        public View_Marks()
        {
            InitializeComponent();
        }

        private void marksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.marksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet1);

        }

        private void View_Marks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.Marks' table. You can move, or remove it, as needed.
            this.marksTableAdapter.Fill(this.studentDataSet1.Marks);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View v = new View();
            v.Show();
        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marksTableAdapter.FillBy3(this.studentDataSet1.Marks, classToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
