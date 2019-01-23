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
    public partial class Student : Form
    {
        int i = 5;
        String a;

        string[] abc = new String[100];




        bool chk = false;
        public Student()
        {
            InitializeComponent();

            abc[0] = "03002235551";
            abc[1] = "bcv";
            abc[2] = "ttt";
            abc[3] = "lmno";
            abc[4] = "fuck";

            serialPort2.Open();
            rfid_CardTextBox.Enabled = false;
            // timeTableDataGridView.Visible = false;

            dateTextBox.Enabled = false;
        }

        private void attendanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timetable.TimeTable' table. You can move, or remove it, as needed.
            this.timeTableTableAdapter.Fill(this.timetable.TimeTable);
            // TODO: This line of code loads data into the 'studentDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.studentDataSet.Table);
            // TODO: This line of code loads data into the 'studentDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.studentDataSet.Attendance);

        }

        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            a = serialPort2.ReadLine();
            chk = false;
            for (var g = 0; g < abc.Length; ++g)
            {
                if (a == abc[g])
                {
                    chk = true;

                }
            }

            if (chk == false)
            {

                abc[i] = a;
                ++i;


                ButtonClick();


            }
            else
            {
                AutoClosingMessageBox.Show("Attendance Already Marked", "Message", 2000);

                Task.Delay(5000);

            }
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                MessageBox.Show(text, caption);
            }

            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }

            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow(null, _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }
        private void ButtonClick()
        {


            if (this.InvokeRequired)
            {

                Action action = ButtonClick;

                this.Invoke(action);
            }
            else
            {


                button1.PerformClick();

            }



        }


        private void button1_Click(object sender, EventArgs e)
        {


            this.attendanceBindingSource.AddNew();
            dateTextBox.Text = DateTime.Now.ToString();
            rfid_CardTextBox.Text = a;
            rfid_cardToolStripTextBox.Text = a;


            this.tableTableAdapter.Roll_No(this.studentDataSet.Table, rfid_cardToolStripTextBox.Text);
            this.Validate();
            this.attendanceBindingSource.EndEdit();
            this.attendanceTableAdapter.Update(this.studentDataSet);
            Task.Delay(500);

            SendMessage();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 ff = new Form1();
            serialPort2.Close();
            ff.Show();
        }

        private void roll_NoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        public void SendMessage()
        {
            String c;
            c = phoneTextBox.Text.ToString();
            serialPort2.Write(c);
            Task.Delay(1000);
            // chk = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy1(this.studentDataSet.Table);
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
                this.tableTableAdapter.FillBy2(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy3(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy4(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy5(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy6ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy6(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy7ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy7(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy8ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy8(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy1(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy2(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy3ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy3(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy4ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy4(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy5ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy5(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy6ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy6(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy7ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy7(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy8ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy8(this.studentDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



    }
}

