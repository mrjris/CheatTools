using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new frmAllocation1()).Show();
        }
        int count = 0;
        private void More(Button btnMore)
        {
            count++;
            Random rand = new Random();
            int x = rand.Next(255), y = rand.Next(255), z = rand.Next(255);
            btnMore.BackColor = Color.FromArgb(x, y, z);
            switch (count)
            {
                case 0:
                    btnMore.Text = "More";
                    break;
                case 1:
                    btnMore.Text = "Đang";
                    break;
                case 2:
                    btnMore.Text = "làm";
                    break;
                case 3:
                    btnMore.Text = "nên";
                    break;
                case 4:
                    btnMore.Text = "chưa";
                    break;
                case 5:
                    btnMore.Text = "có";
                    break;
                case 6:
                    btnMore.Text = "gì";
                    break;
                case 7:
                    btnMore.Text = "đâu.";
                    break;
                case 8:
                    btnMore.Text = "Nhấn";
                    break;
                case 9:
                    btnMore.Text = "ít";
                    break;
                case 10:
                    btnMore.Text = "thôi,";
                    break;
                case 11:
                    btnMore.Text = "làm";
                    break;
                case 12:
                    btnMore.Text = "bài";
                    break;
                case 13:
                    btnMore.Text = "đi.";
                    break;
                case 14:
                    btnMore.Text = "";
                    btnMore.BackColor = System.Drawing.Color.WhiteSmoke;
                    break;
            }
            if (count == 14) count = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            More(button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            More(button8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            More(button7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            More(button6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            More(button5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new frmDiskScheduling()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new frmUNIXsystemAllocation()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new frmLinkList()).Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/Mr.Jris");
        }
    }
}
