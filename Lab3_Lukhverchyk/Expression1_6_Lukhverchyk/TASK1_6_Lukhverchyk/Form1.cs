using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK1_6_Lukhverchyk
{
    public partial class Form1 : Form
    {
        double s;
        double v1;
        double v2;
        double v;
        double t;
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            v1 = Convert.ToDouble(textBox1.Text);
            v2 = Convert.ToDouble(textBox2.Text);
            s = Convert.ToDouble(textBox3.Text);
            v = v1 + v2;
            t = s / v;
            textBox4.Text = Convert.ToString(t);
        }
    }
}
