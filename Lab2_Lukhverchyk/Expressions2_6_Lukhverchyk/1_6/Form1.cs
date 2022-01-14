using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace _1_6
{
    public partial class Form1 : Form
    {
        int score;
        int interval = 1000;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (score == 19)
            {
                using (var soundPlayer = new SoundPlayer(@"C:\Users\SuperMan\Downloads\9876-сало (online-audio-converter.com).wav"))
                {
                    soundPlayer.Play();
                }
                score++;
                label2.Text = Convert.ToString(score);
            }
            else
            {
                using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\chimes.wav"))
                {
                    soundPlayer.Play(); 
                }
                score = score + 1;
                label2.Text = Convert.ToString(score);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            button1.Left = rand.Next(Width - button1.Width-75);
            button1.Top = rand.Next(Height - button1.Height-40);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = timer1.Interval + 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (interval>100)
            {
                timer1.Interval = timer1.Interval - 100;
                interval -= 100;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            score = 0;
            label2.Text = Convert.ToString(score);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
