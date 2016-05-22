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
    public partial class frmUNIXsystemAllocation : Form
    {
        private Hashtable hash = new Hashtable();
        private long maxDirect = 0, maxSingle = 0, maxDouble = 0, maxTriple = 0;
        private long entries;

        public frmUNIXsystemAllocation()
        {
            InitializeComponent();
        }

        private void txtX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            long BlockSize = 0;
            long PointerSize = 0;
            long x = 0;
            long FileLength = 0;
            long b2 = 0, b1 = 0, block = 0, offset = 0;
            string Type = "";
            
            try
            {
                BlockSize = (long)(Convert.ToDouble(txtBlockSize.Text) * (int)hash[cbxBlockSize.Text]);
                PointerSize = (long)(Convert.ToDouble(txtPointerSize.Text) * (int)hash[cbxPointerSize.Text]);
                FileLength = (long)(Convert.ToDouble(txtFileLength.Text) * (int)hash[cbxFileLength.Text]);
                x = (long)(Convert.ToDouble(txtX.Text) * (int)hash[cbxX.Text]);
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
                string[] result = { txtX.Text + " " + cbxX.Text, Type,
                    "N/A","N/A", "N/A", "N/A", "error X < File Size" };
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
                string[] result = { txtX.Text +" "+ cbxX.Text, Type,
                    b2.ToString(), b1.ToString(), block.ToString(), offset.ToString(), location };
                ListViewItem item = new ListViewItem(result);
                foreach (ListViewItem items in History.Items)
                    items.ForeColor = Color.Black;
                item.ForeColor = Color.Red;
                History.Items.Add(item);
            }
            
            string s = "";
        }
        
        private void frmUNIXsystemAllocation_Load(object sender, EventArgs e)
        {
            hash.Add("B", 1);
            hash.Add("KB", 1024);
            hash.Add("MB", 1024 * 1024);
            hash.Add("GB", 1024 * 1024 * 1024);
            update();
        }

        private void txtBlockSize_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void txtPointerSize_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            if (txtBlockSize.Text == "" || txtPointerSize.Text == "")
            {
                MessageBox.Show("Nhập thiếu Block_Size hoặc Pointer_Size. Đề không cho tức là đề sai.");
                return;
            }

            long BlockSize = (long)(Convert.ToDouble(txtBlockSize.Text) * (int)hash[cbxBlockSize.Text]);
            long PointerSize = (long)(Convert.ToDouble(txtPointerSize.Text) * (int)hash[cbxPointerSize.Text]);

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
            while(num >= 1024)
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

            return num + " " +s;
        }

    }
}
