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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
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
            View_Marks vm = new View_Marks();
            vm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Data vd = new View_Data();
            vd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atndnce a1 = new Atndnce();
            a1.Show();
        }
    }
}
