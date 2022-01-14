using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK2_6_Lukhverchyk
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int ch1, ch2, ch3;

        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                ch1 = int.Parse(checkBox1.Text);
            }
            else
            {
                ch1 = 0;
            }
            sum = ch1 + ch2 + ch3;
            label1.Text = sum.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                ch2 = int.Parse(checkBox2.Text);
            }
            else
            {
                ch2 = 0;
            }
            sum = ch1 + ch2 + ch3;
            label1.Text = sum.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                ch3 = int.Parse(checkBox3.Text);
            }
            else
            {
                ch3 = 0;
            }
            sum = ch1 + ch2 + ch3;
            label1.Text = sum.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
