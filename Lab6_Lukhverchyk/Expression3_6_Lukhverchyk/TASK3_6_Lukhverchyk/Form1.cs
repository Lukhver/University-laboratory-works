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
        double UAH = 0, USD = 0;
        public Form1()
        {
            InitializeComponent();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "<-----";
            textBox2.BackColor = Color.White;
            textBox1.BackColor = Color.SandyBrown;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "----->";
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.SandyBrown;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double USD_sell = Convert.ToDouble(textBox2.Text);
            double USD_buy = Convert.ToDouble(textBox1.Text);
            

            if (radioButton2.Checked == true)
            {
                double USD = Convert.ToDouble(textBox3.Text);
                UAH = USD * USD_buy;
                UAH = Math.Round(UAH, 2);
                textBox4.Text = (Convert.ToString(UAH));
            }
            else
            {
                double UAH = Convert.ToDouble(textBox4.Text);
                USD = UAH / USD_sell;
                USD = Math.Round(USD, 2);
                textBox3.Text = (Convert.ToString(USD));
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
