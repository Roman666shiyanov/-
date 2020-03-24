using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int flag;
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            if (flag == 0)
            {
                label1.Text = Convert.ToString(a + b);
            }
            if (flag == 1)
            {
                label1.Text = Convert.ToString(a - b);
            }
            if (flag == 2)
            {
                label1.Text = Convert.ToString(a * b);
            }
            if (flag == 3)
            {
                label1.Text = Convert.ToString(a / b);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 1;
            label2.Text = "+";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = 0;
            label2.Text = "-";
        }

        private void div_Click(object sender, EventArgs e)
        {
            flag = 3;
            label2.Text = "/";
        }

        private void emu_Click(object sender, EventArgs e)
        {
            flag = 4;
            label2.Text = "*";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
