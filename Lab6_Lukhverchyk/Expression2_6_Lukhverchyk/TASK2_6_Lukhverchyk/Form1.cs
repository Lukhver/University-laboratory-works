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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*
            int S = Convert.ToInt32(textBox1.Text);
            int N = 100;
            listBox1.Items.Clear();
            for (int b = 0; b< 10; b++)
                for (int k = 0; k < 20; k++)
                    for (int t = 0; t < 200; t++)
                    {
                        if ((20*b+10*k+t==S)&&(b+k+t==N))
                        {
                            listBox1.Items.Add("Бикiв " + Convert.ToString(b));
                            listBox1.Items.Add("Корiв " + Convert.ToString(k));
                            listBox1.Items.Add("Телят " + Convert.ToString(t));
                        }
                    }
            */

      
            double carbovanci = Convert.ToDouble(textBox1.Text);
            int byk=0, korowa=0, telia=0, golowy = 100;
            listBox1.Items.Clear();
            while ((20 * byk + 10 * korowa + telia != carbovanci) && (byk + korowa + telia != golowy))
            {
                if (korowa == 21)
                {
                    byk++;
                    korowa = korowa - 20;
                }
                else
                {
                    if (telia == 11)
                    {
                        korowa++;
                        telia = telia - 10;
                    }
                    else
                    {
                        telia++;
                    }
                }
            }
            listBox1.Items.Add("Бикiв " + Convert.ToString(byk));
            listBox1.Items.Add("Корiв " + Convert.ToString(korowa));
            listBox1.Items.Add("Телят " + Convert.ToString(telia));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
