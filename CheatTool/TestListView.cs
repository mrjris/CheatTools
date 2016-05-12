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
    public partial class TestListView : Form
    {
        public TestListView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);
            int sum = a + b;
            string[] s = { "1", "2", "3" };
            ListViewItem sum1 = new ListViewItem(a.ToString());
            ListViewItem sum2 = new ListViewItem(s);
            ListViewItem.ListViewSubItem num = new ListViewItem.ListViewSubItem(sum1,b.ToString());
            ListViewItem.ListViewSubItem num1 = new ListViewItem.ListViewSubItem(sum1, sum.ToString());
            sum1.SubItems.Add(num);
            sum1.SubItems.Add(num1);
            listView1.Items.Add(sum1);
            listView1.Items.Add(sum2);
            

        }

    }
}
