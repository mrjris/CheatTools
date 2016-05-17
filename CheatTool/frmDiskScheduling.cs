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
            switch (algorithm)
            {
                case 1:
                    FCFS();
                    break;
                case 2:
                    SSTF();
                    break;
                case 3:
                    Scan();
                    break;
            }
            
        }

        private void Scan()
        {
            int result = 0;
            int[] work = new int[queue.Length + 2];
            int ihead = head;
            Array.Sort(queue);
            if (right)
            {
                result = count - 1 - head + count - 1 - queue[0];
            }else
                result = count - 1 - head + count - 1 - queue[queue.Length -1];

            txtResult.Text = result.ToString();

        }

        Stack<int> sleft = new Stack<int>();
        Stack<int> sright = new Stack<int>();
        private void SSTF()
        {
            int result = 0;
            int[] work = new int[queue.Length];
            int ihead = head;
            Array.Sort(queue);
            
            for (int i = 0; i < queue.Length; i++)
                if (queue[i] < head) sleft.Push(queue[i]);
            
            for (int i = queue.Length - 1; i > 0; i--)
                if (queue[i] > head) sright.Push(queue[i]);

            for (int i = 0; i < queue.Length; i++)
            {
                work[i] = findNextSSTF(ihead);
                ihead = work[i];
            }

            result = calculate(work);
            txtResult.Text = result.ToString();
            foreach (int x in work)
                txtHistory.Text += x.ToString() + "\r\n";
        }

        private int findNextSSTF(int ihead)
        {
            if (sleft.Count == 0) return sright.Pop();
            if (sright.Count == 0) return sleft.Pop();

            if ((ihead - sleft.Peek()) > (sright.Peek() - ihead))
            {
                return sright.Pop();
            }
            else
            {
                return sleft.Pop();
            }
            return 0;
        }

        public void FCFS()
        {
            int result = calculate(queue);
            txtResult.Text = result.ToString();
        }

        private int calculate(int[] queue)
        {
            int[] work = queue;
            int sum = 0;
            int ihead = head;
            for (int i = 0; i < work.Length; i++)
            {
                sum += Math.Abs(ihead - work[i]);
                ihead = work[i];
            }
            return sum;
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
