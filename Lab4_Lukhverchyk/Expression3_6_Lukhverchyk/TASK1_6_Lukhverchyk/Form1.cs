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
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] Num_list = new int[100];
            Random rand = new Random();
            int N = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < N; i++)
            {
                Num_list[i] = rand.Next(100);
                listBox1.Items.Add(Convert.ToString(Num_list[i]));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int temp = Convert.ToInt32(listBox1.Items[i]);
                if ((temp % 2 == 1) && (i % 2 == 0))
                {
                    k++;
                }
            }
            textBox1.Text = Convert.ToString(k);
        }
    }
}
