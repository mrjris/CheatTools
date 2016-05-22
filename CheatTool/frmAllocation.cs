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
    public partial class frmAllocation : Form
    {
        public frmAllocation()
        {
            InitializeComponent();
        }
        Hashtable hash = new Hashtable();

        private void frmAllocation_Load(object sender, EventArgs e)
        {
            hash.Add("Byte", 1);
            hash.Add("KB", 1024);
            hash.Add("MB", 1024 * 1024);
            hash.Add("GB", 1024 * 1024 * 1024);
        }

        private void txtX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long FileLength = 0, BlockSize = 0;
            long x = 0;
            try
            {
                FileLength = (long)(Convert.ToDouble(txtFileSize1.Text) * (int)hash[cbxFileSize1.Text]);
                BlockSize = (long)(Convert.ToDouble(txtBlockSize1.Text) * (int)hash[cbxBlockSize1.Text]);
                x = (long)(Convert.ToDouble(txtX1.Text) * (int)hash[cbxX1.Text]);
            }
            catch
            {
                MessageBox.Show("Nhập tử tế đi.");
            }

            if (x > FileLength || x < 0)
            {
                string[] result = { "Block, Offset", txtX1.Text + " " + cbxX1.Text,
                    "N/A","N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
            else
            {
                long offset = x % BlockSize;
                long block = x / BlockSize;
                string location = "(" + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { "Block, Offset",txtX1.Text +" "+ cbxX1.Text,
                    "N/A","N/A", block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }

        }

        private void txtX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long FileLength = 0;
            long BlockSize = 0;
            long x = 0;
            int n = 0;
            try
            {
                FileLength = (long)(Convert.ToDouble(txtFileSize2.Text) * (int)hash[cbxFileSize2.Text]);
                BlockSize = (long)(Convert.ToDouble(txtBlockSize2.Text) * (int)hash[cbxBlockSize2.Text]);
                x = (long)(Convert.ToDouble(txtX2.Text) * (int)hash[cbxX2.Text]);
                n = Convert.ToInt32(txtN.Text);
            }
            catch
            {
                MessageBox.Show("Có lỗi. Mời nhập lại.");
            }

            if (x > FileLength || x < 0)
            {
                string[] result = { "Extend-Base", txtX1.Text + " " + cbxX1.Text,
                    "N/A","N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
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
                string[] result = { "Extend-Base",txtX2.Text +" "+ cbxX2.Text,
                    "N/A",extent.ToString(), block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
        }

        private void txtX3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long blockSize = 0;
            long pointerSize = 0;
            long fileLength = 0;
            long x = 0;
            try
            {
                blockSize = (long)(Convert.ToDouble(txtBlockSize3.Text) * (int)hash[cbxBlockSize3.Text]);
                pointerSize = (long)(Convert.ToDouble(txtPointer3.Text) * (int)hash[cbxPointer3.Text]);
                fileLength = (long)(Convert.ToDouble(txtFileSize3.Text) * (int)hash[cbxFileSize3.Text]);
                x = (long)(Convert.ToDouble(txtX3.Text) * (int)hash[cbxX3.Text]);
            }
            catch
            {
                MessageBox.Show("Lỗi. Nhập lại đi.");
            }

            if (x > fileLength || x < 0)
            {
                string[] result = { "Linked List",txtX3.Text + " " + cbxX3.Text,
                    "N/A","N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
            else
            {
                blockSize -= pointerSize;
                long offset = x % blockSize + pointerSize;
                long block = x / blockSize;
                string location = "(" + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { "Linked List",txtX3.Text +" "+ cbxX3.Text,
                    "N/A","N/A", block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
        }

        private void txtX4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long blockSize = 0;
            long pointerSize = 0;
            long fileLength = 0;
            long x = 0;
            try
            {
                blockSize = (long)(Convert.ToDouble(txtBlockSize4.Text) * (int)hash[cbxBlockSize4.Text]);
                pointerSize = (long)(Convert.ToDouble(txtPointer4.Text) * (int)hash[cbxPointer4.Text]);
                fileLength = (long)(Convert.ToDouble(txtFileSize4.Text) * (int)hash[cbxFileSize4.Text]);
                x = (long)(Convert.ToDouble(txtX4.Text) * (int)hash[cbxX4.Text]);
            }
            catch
            {
                MessageBox.Show("Lỗi. Nhập lại đi.");
            }

            if (x > fileLength || x < 0)
            {
                string[] result = { "Linked List",txtX4.Text + " " + cbxX4.Text,
                    "N/A","N/A", "N/A", "N/A", "error" };
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
                string[] result = { "Linked List",txtX4.Text + " " + cbxX4.Text,
                    "N/A",extent.ToString(), block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
        }

        private void txtX5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long FileLength = 0, BlockSize = 0;
            long pointerSize = 0;
            long KTTD = 0;
            long x = 0;
            try
            {
                FileLength = (long)(Convert.ToDouble(txtFileSize5.Text) * (int)hash[cbxFileSize5.Text]);
                BlockSize = (long)(Convert.ToDouble(txtBlockSize5.Text) * (int)hash[cbxBlockSize5.Text]);
                pointerSize = (long)(Convert.ToDouble(txtPointer5.Text) * (int)hash[cbxPointer5.Text]);
                x = (long)(Convert.ToDouble(txtX5.Text) * (int)hash[cbxX5.Text]);
            }
            catch
            {
                MessageBox.Show("Nhập tử tế đi.");
            }

            KTTD = BlockSize / pointerSize * BlockSize;
            //if (FileLength > KTTD)
            //{
            //    string[] result = { "Indexed", txtX5.Text + " " + cbxX5.Text,
            //        "N/A", "N/A", "N/A", "File Size > MaxSize => Invalid" };
            //    ListViewItem item = new ListViewItem(result);
            //    foreach (ListViewItem items in History.Items)
            //        items.ForeColor = Color.Black;
            //    item.ForeColor = Color.Red;
            //    History.Items.Add(item);
            //}else
            if (x > FileLength || x < 0)
            {
                string[] result = { "Block, Offset", txtX5.Text + " " + cbxX5.Text,
                    "N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
            else
            {
                long offset = x % BlockSize;
                long block = x / BlockSize;
                string location = "(" + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { "Index",txtX5.Text +" "+ cbxX5.Text,
                    "N/A","N/A", block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
        }

        private void txtX6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long FileLength = 0, BlockSize = 0;
            long pointerSize = 0;
            long KTTD = 0;
            long x = 0;
            long entries = 0;
            try
            {
                FileLength = (long)(Convert.ToDouble(txtFileSize6.Text) * (int)hash[cbxFileSize6.Text]);
                BlockSize = (long)(Convert.ToDouble(txtBlockSize5.Text) * (int)hash[cbxBlockSize6.Text]);
                pointerSize = (long)(Convert.ToDouble(txtPointer6.Text) * (int)hash[cbxPointer6.Text]);
                x = (long)(Convert.ToDouble(txtX6.Text) * (int)hash[cbxX6.Text]);
            }
            catch
            {
                MessageBox.Show("Nhập tử tế đi.");
            }

            KTTD = BlockSize / pointerSize * BlockSize;
            //if (FileLength > KTTD)
            //{
            //    string[] result = { "Indexed", txtX6.Text + " " + cbxX6.Text,
            //        "N/A", "N/A", "N/A", "File Size > MaxSize => Invalid" };
            //    ListViewItem item = new ListViewItem(result);
            //    foreach (ListViewItem items in History.Items)
            //        items.ForeColor = Color.Black;
            //    item.ForeColor = Color.Red;
            //    History.Items.Add(item);
            //}
            //else
            if (x > FileLength || x < 0)
            {
                string[] result = { "Block, Offset", txtX6.Text + " " + cbxX6.Text,
                    "N/A", "N/A", "N/A", "error" };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
            else
            {
                entries = BlockSize / pointerSize;
                long offset = x % BlockSize;
                x /= BlockSize;
                long index = x / entries;
                long block = x % entries;
                string location = "("+index.ToString() + "," + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { "2-Level Index",txtX6.Text +" "+ cbxX6.Text,
                    "N/A",index.ToString(), block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
        }
        private long maxDirect = 0, maxSingle = 0, maxDouble = 0, maxTriple = 0;
        private long entries;

        private void txtBlockSize7_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void txtFileSize7_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void txtX7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            update();
            long BlockSize = 0;
            long PointerSize = 0;
            long x = 0;
            long FileLength = 0;
            long b2 = 0, b1 = 0, block = 0, offset = 0;
            string Type = "";

            try
            {
                BlockSize = (long)(Convert.ToDouble(txtBlockSize7.Text) * (int)hash[cbxBlockSize7.Text]);
                PointerSize = (long)(Convert.ToDouble(txtPointer7.Text) * (int)hash[cbxPointer7.Text]);
                FileLength = (long)(Convert.ToDouble(txtFileSize7.Text) * (int)hash[cbxFileSize7.Text]);
                x = (long)(Convert.ToDouble(txtX7.Text) * (int)hash[cbxX7.Text]);
            }
            catch
            {
                MessageBox.Show("Nhập tử tế đi.");
            }

            if (x <= maxDirect && x > 0) Type = "Direct block";
            else if (x <= maxSingle) Type = "Single indirect block";
            else if (x <= maxDouble) Type = "Double indirect block";
            else if (x <= maxTriple) Type = "Triple indirect block";
            else Type = "error";


            if (x > FileLength || x < 0)
            {
                string[] result = {Type, txtX7.Text + " " + cbxX7.Text, 
                    "N/A", "N/A", "N/A", "error X < File Size" };
                ListViewItem item = new ListViewItem(result);
                History.Items.Add(item);
            }
            else
            {

                switch (Type)
                {
                    case "Direct block":
                        block = x / BlockSize;
                        offset = x % BlockSize;
                        break;
                    case "Single indirect block":
                        x -= maxDirect;
                        block = x / BlockSize;
                        offset = x % BlockSize;
                        break;
                    case "Double indirect block":
                        x = x - maxDirect - maxSingle;
                        block = x / BlockSize;
                        b1 = block / entries;
                        block = block % entries;
                        offset = x % BlockSize;
                        break;
                    case "Triple indirect block":
                        x = x - maxDirect - maxSingle - maxDouble;
                        block = x / BlockSize;
                        offset = x % BlockSize;
                        b2 = block / (entries * entries);
                        block %= (entries * entries);
                        b1 = block / entries;
                        block %= entries;
                        break;
                }
                
                string location = "(" + block.ToString() + "," + offset.ToString() + ")";
                string[] result = { Type, txtX7.Text +" "+ cbxX7.Text, 
                    b2.ToString(), b1.ToString(), block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }

            string s = "";
        }

        private void update()
        {
            if (txtBlockSize7.Text == "" || txtPointer7.Text == "")
            {
                MessageBox.Show("Nhập thiếu Block_Size hoặc Pointer_Size. Đề không cho tức là đề sai.");
                return;
            }

            long BlockSize = (long)(Convert.ToDouble(txtBlockSize7.Text) * (int)hash[cbxBlockSize7.Text]);
            long PointerSize = (long)(Convert.ToDouble(txtPointer7.Text) * (int)hash[cbxPointer7.Text]);

            long directCount = Convert.ToInt32(txtDirectCount.Text);
            long singleCount = Convert.ToInt32(txtSingleCount.Text);
            long doubleCount = Convert.ToInt32(txtDoubleCount.Text);
            long tripleCount = Convert.ToInt32(txtTripleCount.Text);

            entries = BlockSize / PointerSize;
            maxDirect = directCount * BlockSize;
            maxSingle = singleCount * entries * BlockSize;
            maxDouble = doubleCount * entries * entries * BlockSize;
            maxTriple = tripleCount * entries * entries * entries * BlockSize;

            txtMaxDirect.Text = convert(maxDirect);
            txtMaxSingle.Text = convert(maxSingle);
            txtMaxDouble.Text = convert(maxDouble);
            txtMaxTriple.Text = convert(maxTriple);
            txtEntries.Text = entries.ToString();

            Hashtable exp2 = new Hashtable();

            //(directCount * 0 * 4).ToString() + "+" +
            /*  512 byte block and a big file: 493 MB, so how amny index blocks are needed
                for this. entries = 100. the calculations were as follows:
                Direct blocks: 0
                Single indirect: 1
                Double indirect: 1 + 100 = 101
                Trpile indirect: 1 + 100 + 100^2
                Which gives a total of 10203.
                => 3*Single + 2*Double * entries + 1*Triple * entries * entries
             */
            txtIndexedBlocks.Text = (singleCount * 3).ToString() + " + " +
                "2^" + (Convert.ToString(doubleCount * entries * 2, 2).Count() - 1).ToString() + "+" +
                "2^" + (Convert.ToString(tripleCount * entries * entries * 1, 2).Count() - 1).ToString();

        }
        private string convert(long num)
        {
            long i = 1;
            while (num >= 1024)
            {
                num /= 1024;
                i++;
            }
            string s = "";
            switch (i)
            {
                case 1:
                    s = "B";
                    break;
                case 2:
                    s = "KB";
                    break;
                case 3:
                    s = "MB";
                    break;
                case 4:
                    s = "GB";
                    break;
                case 5:
                    s = "TB";
                    break;
            }

            return num + " " + s;
        }
    }
}
