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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
              MessageBox.Show(" RFID BASED ATTENDANCE SYSTEM \n\n CREATED BY: \n ASIM ZULFIQAR \n HARIS KHAN \n\n CONTACT NO : 03442855365", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload u = new Upload();
            u.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            View v = new View();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ff = new Form1();
            ff.Show();
        }
    }
}
