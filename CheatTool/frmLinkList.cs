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
    public partial class frmLinkList : Form
    {
        Hashtable hash = new Hashtable();
        public frmLinkList()
        {
            InitializeComponent();
        }

        private void frmLinkList_Load(object sender, EventArgs e)
        {
            hash.Add("B", 1);
            hash.Add("KB", 1024);
            hash.Add("MB", 1024 * 1024);
            hash.Add("GB", 1024 * 1024 * 1024);
        }

        private void txtX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long blockSize = 0;
            long pointerSize = 0;
            long fileLength = 0;
            long x = 0;
            try
            {
                blockSize = (long)(Convert.ToDouble(txtBlockSize.Text) * (int)hash[cbxBlockSize.Text]);
                pointerSize = (long)(Convert.ToDouble(txtPointerSize.Text) * (int)hash[cbxPointerSize.Text]);
                fileLength = (long)(Convert.ToDouble(txtFileLength.Text) * (int)hash[cbxFileLength.Text]);
                x = (long)(Convert.ToDouble(txtX.Text) * (int)hash[cbxX.Text]);
            }
            catch
            {
                MessageBox.Show("Lỗi. Nhập lại đi.");
            }

            if (x > fileLength || x < 0)
            {
                string[] result = { txtX.Text + " " + cbxX.Text, txtBlockSize.Text + " " + cbxBlockSize.Text,
                    "N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                History.Items.Add(item);
            }
            else
            {
                blockSize -= pointerSize;
                long offset = x % blockSize + pointerSize;
                long block = x / blockSize;
                string location = "(" + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { txtX.Text +" "+ cbxX.Text, txtBlockSize.Text +" "+ cbxBlockSize.Text,
                    "N/A", block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }


        }

        private void txtExX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long blockSize = 0;
            long pointerSize = 0;
            long fileLength = 0;
            long x = 0;
            try
            {
                blockSize = (long)(Convert.ToDouble(txtExBlockSize.Text) * (int)hash[cbxExBlockSize.Text]);
                pointerSize = (long)(Convert.ToDouble(txtExPointerSize.Text) * (int)hash[cbxExPointerSize.Text]);
                fileLength = (long)(Convert.ToDouble(txtExFileLength.Text) * (int)hash[cbxExFileLength.Text]);
                x = (long)(Convert.ToDouble(txtExX.Text) * (int)hash[cbxExX.Text]);
            }
            catch
            {
                MessageBox.Show("Lỗi. Nhập lại đi.");
            }

            if (x > fileLength || x < 0)
            {
                string[] result = { txtX.Text + " " + cbxX.Text, txtBlockSize.Text + " " + cbxBlockSize.Text,
                    "N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                History.Items.Add(item);
            }
            else
            {
                long pCount = blockSize / pointerSize - 1;
                long offset = x % blockSize;
                x /= blockSize;
                long extent = x / pCount;
                long block = x % pCount;

                string location = "(" + extent.ToString() + "," + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { txtExX.Text +" "+ cbxExX.Text, txtExBlockSize.Text +" "+ cbxExBlockSize.Text,
                    extent.ToString(), block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
        }
    }
}
