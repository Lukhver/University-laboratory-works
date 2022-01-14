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
        double x;
        double y1;
        double y2;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y1 = Math.Sqrt(Math.Abs(x - 1.0) + (Math.Sin(x)));
            textBox2.Text = Convert.ToString(y1);
            y2 = 1 + (1.0 / x) + (1.0 / Math.Pow(x,2.0));
            textBox3.Text = Convert.ToString(y2);
            y1 = Math.Round(y1);
            y2 = Math.Round(y2);
            textBox4.Text = Convert.ToString(y1);
            textBox5.Text = Convert.ToString(y2);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
