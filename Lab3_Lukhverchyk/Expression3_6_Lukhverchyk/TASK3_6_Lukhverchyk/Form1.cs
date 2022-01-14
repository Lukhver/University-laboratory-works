using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK3_6_Lukhverchyk
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        int c;
        int poz3;
        int poz2;
        int poz1;
        int max;

        public Form1()
        {
            InitializeComponent();
        }

        private void swap()
        {
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            if (a == b && a == c)
            {
                a = b;
                b = c;
                max = a;
                textBox4.Text = Convert.ToString(max);
                label7.Visible = true;
                label8.Visible = true;
            }
            else
            {
                label5.Visible = true;
                label6.Visible = true;
                if (a > b)
                {
                    poz3 = b;
                    if (a > c)
                    {
                        max = a;
                        poz1 = a;
                        poz2 = c;
                    }
                    else
                    {
                        max = c;
                        poz1 = c;
                        poz2 = a;
                    }
                }
                if (a < b)
                {
                    poz3 = a;
                    if (b > c)
                    {
                        max = b;
                        poz1 = b;
                        poz2 = c;
                    }
                    else
                    {
                        max = c;
                        poz1 = c;
                        poz2 = b;
                    }
                }
                textBox3.Text = Convert.ToString(poz1);
                textBox2.Text = Convert.ToString(poz2);
                textBox1.Text = Convert.ToString(poz3);
                textBox4.Text = Convert.ToString(max);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            swap();
            swap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
