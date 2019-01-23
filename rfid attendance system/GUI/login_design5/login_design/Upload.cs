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
    public partial class Upload : Form
    {
        public Upload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload_Data ud = new Upload_Data();
            ud.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Menu mm = new Main_Menu();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            upload_marks upm = new upload_marks();
            upm.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Assignment tt = new Assignment();
            tt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fee f = new Fee();
            f.Show();
        }
    }
}
