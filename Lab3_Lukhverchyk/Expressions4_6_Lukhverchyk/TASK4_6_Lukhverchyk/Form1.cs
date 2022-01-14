using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK4_6_Lukhverchyk
{
    public partial class Form1 : Form
    {

        double x;
        double y;
        double z;
        double B;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            B = Math.Sqrt(10.0 * (Math.Pow(x, 1.0 / 3.0) + Math.Pow(x, y + 2.0))) * ((Math.Asin(z) * Math.Asin(z)) - Math.Abs(x - y));
            label4.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = Convert.ToString(B);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

       

        
    }
}
