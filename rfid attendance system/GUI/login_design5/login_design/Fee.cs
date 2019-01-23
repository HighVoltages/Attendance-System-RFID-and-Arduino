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
    public partial class Fee : Form
    {
        public Fee()
        {
            InitializeComponent();
        }

        private void feeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet1);

        }

        private void Fee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet1.Fee' table. You can move, or remove it, as needed.
            this.feeTableAdapter.Fill(this.studentDataSet1.Fee);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.feeTableAdapter.FillBy(this.studentDataSet1.Fee, classToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload up = new Upload();
            up.Show();
        }
    }
}
