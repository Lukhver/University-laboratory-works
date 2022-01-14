using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_6
{
    public partial class Form1 : Form
    {
        int rok; // це по польскі
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rok = Convert.ToInt32(textBox1.Text);
            MessageBox.Show("Вам ймовірно " + Convert.ToString(18 + rok) + " років");
            label2.Text = "Вам ймовірно " + Convert.ToString(18 + rok) + " років";
            label1.Visible = false;
            label2.Visible = true;

        }
    }
}


