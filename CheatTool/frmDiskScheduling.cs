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
    public partial class frmDiskScheduling : Form
    {
        /*algorithm = -1 ~ Do nothing
         * 1 ~ FCFS
         * 2 ~ SSTF
         * 3 ~ Scan
         * 4 ~ CScan
         * 5 ~ Look
         * 6 ~ CLook
         */
        int algorithm = -1;
        bool right = true;
        int[] queue = new int[100];
        int count = 200;
        int head = 0;


        public frmDiskScheduling()
        {
            InitializeComponent();
        }
        private void frmDiskScheduling_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            readData();
        }

        private void readData()
        {
            string s = txtQueue.Text;
            string[] dim = { ",", ".", " ", "\t", "\r\t"};
            string[] words = s.Split(dim, StringSplitOptions.RemoveEmptyEntries);
            queue = new int[words.Length];
            int i = 0;
            foreach (string word in words)
                queue[i++] = Convert.ToInt32(word);
            foreach (int x in queue)
                txtHistory.Text += x.ToString() + "\r\n";
            count = Convert.ToInt32(txtCount.Text);
            head = Convert.ToInt32(txtHead.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) { algorithm = 2; }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { algorithm = 1; }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 3;
            btnLeft.Visible = true;
            btnRight.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 4;
            btnLeft.Visible = true;
            btnRight.Visible = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 5;
            btnLeft.Visible = true;
            btnRight.Visible = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            algorithm = 6;
            btnLeft.Visible = true;
            btnRight.Visible = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            right = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            right = false;
        }
    }
}
