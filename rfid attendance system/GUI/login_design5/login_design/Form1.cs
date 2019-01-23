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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       


     

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "yltc" && textBox2.Text.ToString() == "exam")
            {
                this.Hide();
                Main_Menu f = new Main_Menu();
                f.Show();
            }
            else
                MessageBox.Show("Sorry! Incorrect Login Details.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" RFID BASED ATTENDANCE SYSTEM \n\n CREATED BY: \n ASIM ZULFIQAR \n HARIS KHAN \n CONTACT NO :03442855365", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student s = new Student();
            s.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
