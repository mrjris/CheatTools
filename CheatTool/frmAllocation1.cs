using System;
using System.Collections;
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
    public partial class frmAllocation1 : Form
    {
        Hashtable hash = new Hashtable();
        

        public frmAllocation1()
        {
            InitializeComponent();           
        }

        private void frmAllocation1_Load(object sender, EventArgs e)
        {
            hash.Add("B", 1);
            hash.Add("KB", 1024);
            hash.Add("MB", 1024 * 1024);
            hash.Add("GB", 1024 * 1024 * 1024);
            long FileLength = Convert.ToInt64(txtFileLength.Text) * (int)hash[comboBox2.Text];
            long BlockSize = Convert.ToInt64(txtBlockSize.Text) * (int)hash[comboBox1.Text];
            long blocks = FileLength / BlockSize;

            txtBlocks.Text = blocks.ToString();
        }


        private void txtBlockSize_TextChanged(object sender, EventArgs e)
        {
            if (txtFileLength.Text != "" && txtBlockSize.Text != "")
            {
                long FileLength = Convert.ToInt64(txtFileLength.Text) * (int)hash[comboBox2.Text];
                long BlockSize = Convert.ToInt64(txtBlockSize.Text) * (int)hash[comboBox1.Text];
                long blocks = FileLength / BlockSize;

                txtBlocks.Text = blocks.ToString();
            }
        }
       
        private void txtFileLength_TextChanged(object sender, EventArgs e)
        {
            if (txtFileLength.Text != "" && txtBlockSize.Text != "")
            {
                long FileLength = Convert.ToInt64(txtFileLength.Text) * (int)hash[comboBox2.Text];
                long BlockSize = Convert.ToInt64(txtBlockSize.Text) * (int)hash[comboBox1.Text];
                long blocks = FileLength / BlockSize;

                txtBlocks.Text = blocks.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            long FileLength = 0, BlockSize = 0;
            long x = 0;
            try
            {
                FileLength = Convert.ToInt32(txtFileLength.Text) * (int)hash[comboBox2.Text];
                BlockSize = Convert.ToInt32(txtBlockSize.Text) * (int)hash[comboBox1.Text];
                x = (long)(Convert.ToInt64(txtX.Text) * (int)hash[cbxX.Text]);
            }
            catch
            {
                MessageBox.Show("Nhập tử tế đi.");
            }

            if (x > FileLength || x < 0)
            {
                string[] result = { x.ToString(), BlockSize.ToString(), "N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                History.Items.Add(item);
            }
            else
            {
                long offset = x % BlockSize;
                long block = x / BlockSize;
                string location = "(" + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { x.ToString(), BlockSize.ToString(), "N/A", block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                History.Items.Add(item);
            } 
            
        }

        private void btnExStart_Click(object sender, EventArgs e)
        {
            long FileLength = 0;
            long BlockSize = 0;
            long x = 0;
            int n = 0;
            try
            {
                FileLength = Convert.ToInt64(txtExFileLength.Text) * (int)hash[comboBox4.Text];
                BlockSize = Convert.ToInt32(txtExBlockSize.Text) * (int)hash[comboBox3.Text];
                x = (long)(Convert.ToInt64(textBox1.Text) * (int)hash[cbxExX.Text]);
                n = Convert.ToInt32(txtExCount.Text);          
            }
            catch
            {
                MessageBox.Show("Có lỗi. Mời nhập lại.");
            }


            if (x > FileLength || x < 0)
            {
                string[] result = { x.ToString(), BlockSize.ToString(), "N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                History.Items.Add(item);
            }
            else
            {
                long offset = x % BlockSize;
                BlockSize /= 1024;
                long tempx = x / 1024;
                long exSize = BlockSize * n;
                long extent = tempx / exSize;
                long block = tempx % exSize;
                block /= BlockSize;
                string location = "(" + extent.ToString() + "," + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { x.ToString(), BlockSize.ToString(), extent.ToString(), block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                History.Items.Add(item);
            }

        }
    }
}
