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
    public partial class MainForm : Form
    {
        int count = 0;
        Random rnd;
        char[] spec_char = new char[] { '%', '*', ')', '?', '#', '$', '^', '&', '~' };

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Програма MyUtilites містить набір невеликих програм, які\nможуть стати у нагоді.А головне навчить мене основам програмування на C#.\nАвтор: Сергій Лухверчик", "Про програму");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
            lblRandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
                    i++;
                    if (i > 1000)
                    {
                        break;
                    }
                }
                    if (i < 1000)
                    {
                        tbRandom.AppendText(n + "\r\n");
                    }
                    else tbRandom.AppendText(n + "\r\n");
            }
        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (clbPassword.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < nudPasswordLength.Value; i++)

            {
                int n = rnd.Next(0, clbPassword.CheckedItems.Count);
                string s = clbPassword.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Цифри":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Рядкові букви":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Пропісні букви":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                }
                tbPassword.Text = password;
            }
            tbPassword.Text = password;
            Clipboard.SetText(password);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            clbPassword.SetItemChecked(0, true);
            clbPassword.SetItemChecked(1, true);
        }

        private void clbPassword_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudPasswordLength_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
