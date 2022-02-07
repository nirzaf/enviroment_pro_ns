using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace enviroment_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = Environment.MachineName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = Environment.UserName;
            MessageBox.Show("Welcome to My Application: " + Environment.UserName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = Environment.ProcessorCount.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = Environment.TickCount;
            Int32 j;
            j = i / 1000;
            this.textBox4.Text = j.ToString();
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox5.Text = System.Windows.Forms.Screen.PrimaryScreen.Bounds.ToString();
            this.textBox6.Text = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Int32 w;
            w = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            Int32 h;
            h = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            if ((w<=1400 ) || ( h<=1300))
            {
                MessageBox.Show("Minimum resolution is : 1400 width X 1300 Height");
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox7.Text = Application.CompanyName;
            this.textBox8.Text = Application.ProductName;
            this.textBox9.Text = Application.ProductVersion;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button7_Click(sender, e);
        }
    }
}
