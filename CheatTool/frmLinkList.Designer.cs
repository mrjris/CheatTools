namespace CheatTool
{
    partial class frmLinkList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLinkList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxX = new System.Windows.Forms.ComboBox();
            this.cbxFileLength = new System.Windows.Forms.ComboBox();
            this.cbxPointerSize = new System.Windows.Forms.ComboBox();
            this.cbxBlockSize = new System.Windows.Forms.ComboBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtFileLength = new System.Windows.Forms.TextBox();
            this.txtPointerSize = new System.Windows.Forms.TextBox();
            this.txtBlockSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.History = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExBlockSize = new System.Windows.Forms.TextBox();
            this.txtExPointerSize = new System.Windows.Forms.TextBox();
            this.txtExFileLength = new System.Windows.Forms.TextBox();
            this.txtExX = new System.Windows.Forms.TextBox();
            this.cbxExBlockSize = new System.Windows.Forms.ComboBox();
            this.cbxExPointerSize = new System.Windows.Forms.ComboBox();
            this.cbxExFileLength = new System.Windows.Forms.ComboBox();
            this.cbxExX = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caculator";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.cbxExX);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cbxExFileLength);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cbxExPointerSize);
            this.groupBox5.Controls.Add(this.txtExBlockSize);
            this.groupBox5.Controls.Add(this.cbxExBlockSize);
            this.groupBox5.Controls.Add(this.txtExPointerSize);
            this.groupBox5.Controls.Add(this.txtExX);
            this.groupBox5.Controls.Add(this.txtExFileLength);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(318, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(349, 144);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Linked Index block Allocation";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbxX);
            this.groupBox3.Controls.Add(this.cbxFileLength);
            this.groupBox3.Controls.Add(this.cbxPointerSize);
            this.groupBox3.Controls.Add(this.cbxBlockSize);
            this.groupBox3.Controls.Add(this.txtX);
            this.groupBox3.Controls.Add(this.txtFileLength);
            this.groupBox3.Controls.Add(this.txtPointerSize);
            this.groupBox3.Controls.Add(this.txtBlockSize);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 144);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Linked List Allocation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(35, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            // 
            // cbxX
            // 
            this.cbxX.FormattingEnabled = true;
            this.cbxX.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxX.Location = new System.Drawing.Point(179, 107);
            this.cbxX.Name = "cbxX";
            this.cbxX.Size = new System.Drawing.Size(76, 21);
            this.cbxX.TabIndex = 2;
            this.cbxX.Text = "KB";
            // 
            // cbxFileLength
            // 
            this.cbxFileLength.FormattingEnabled = true;
            this.cbxFileLength.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxFileLength.Location = new System.Drawing.Point(179, 69);
            this.cbxFileLength.Name = "cbxFileLength";
            this.cbxFileLength.Size = new System.Drawing.Size(76, 21);
            this.cbxFileLength.TabIndex = 2;
            this.cbxFileLength.Text = "MB";
            // 
            // cbxPointerSize
            // 
            this.cbxPointerSize.FormattingEnabled = true;
            this.cbxPointerSize.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxPointerSize.Location = new System.Drawing.Point(179, 48);
            this.cbxPointerSize.Name = "cbxPointerSize";
            this.cbxPointerSize.Size = new System.Drawing.Size(76, 21);
            this.cbxPointerSize.TabIndex = 2;
            this.cbxPointerSize.Text = "B";
            // 
            // cbxBlockSize
            // 
            this.cbxBlockSize.FormattingEnabled = true;
            this.cbxBlockSize.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxBlockSize.Location = new System.Drawing.Point(179, 25);
            this.cbxBlockSize.Name = "cbxBlockSize";
            this.cbxBlockSize.Size = new System.Drawing.Size(76, 21);
            this.cbxBlockSize.TabIndex = 2;
            this.cbxBlockSize.Text = "KB";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(73, 108);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            this.txtX.Text = "15.25";
            this.txtX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtX_KeyDown);
            // 
            // txtFileLength
            // 
            this.txtFileLength.Location = new System.Drawing.Point(73, 70);
            this.txtFileLength.Name = "txtFileLength";
            this.txtFileLength.Size = new System.Drawing.Size(100, 20);
            this.txtFileLength.TabIndex = 1;
            this.txtFileLength.Text = "15.4";
            // 
            // txtPointerSize
            // 
            this.txtPointerSize.Location = new System.Drawing.Point(73, 48);
            this.txtPointerSize.Name = "txtPointerSize";
            this.txtPointerSize.Size = new System.Drawing.Size(100, 20);
            this.txtPointerSize.TabIndex = 1;
            this.txtPointerSize.Text = "4";
            // 
            // txtBlockSize
            // 
            this.txtBlockSize.Location = new System.Drawing.Point(73, 25);
            this.txtBlockSize.Name = "txtBlockSize";
            this.txtBlockSize.Size = new System.Drawing.Size(100, 20);
            this.txtBlockSize.TabIndex = 1;
            this.txtBlockSize.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pointer_size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block_size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.History);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // History
            // 
            this.History.AllowColumnReorder = true;
            this.History.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History.Location = new System.Drawing.Point(3, 16);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(664, 255);
            this.History.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.History.TabIndex = 0;
            this.History.UseCompatibleStateImageBehavior = false;
            this.History.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "X";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Block size";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "index";
            this.columnHeader3.Width = 97;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "block";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "offset";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "location";
            this.columnHeader6.Width = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Block_size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pointer_size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "File Length";
            // 
            // txtExBlockSize
            // 
            this.txtExBlockSize.Location = new System.Drawing.Point(70, 30);
            this.txtExBlockSize.Name = "txtExBlockSize";
            this.txtExBlockSize.Size = new System.Drawing.Size(100, 20);
            this.txtExBlockSize.TabIndex = 1;
            this.txtExBlockSize.Text = "2";
            // 
            // txtExPointerSize
            // 
            this.txtExPointerSize.Location = new System.Drawing.Point(70, 53);
            this.txtExPointerSize.Name = "txtExPointerSize";
            this.txtExPointerSize.Size = new System.Drawing.Size(100, 20);
            this.txtExPointerSize.TabIndex = 1;
            this.txtExPointerSize.Text = "4";
            // 
            // txtExFileLength
            // 
            this.txtExFileLength.Location = new System.Drawing.Point(70, 75);
            this.txtExFileLength.Name = "txtExFileLength";
            this.txtExFileLength.Size = new System.Drawing.Size(100, 20);
            this.txtExFileLength.TabIndex = 1;
            this.txtExFileLength.Text = "20";
            // 
            // txtExX
            // 
            this.txtExX.Location = new System.Drawing.Point(70, 113);
            this.txtExX.Name = "txtExX";
            this.txtExX.Size = new System.Drawing.Size(100, 20);
            this.txtExX.TabIndex = 1;
            this.txtExX.Text = "15.5";
            this.txtExX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtExX_KeyDown);
            // 
            // cbxExBlockSize
            // 
            this.cbxExBlockSize.FormattingEnabled = true;
            this.cbxExBlockSize.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxExBlockSize.Location = new System.Drawing.Point(176, 30);
            this.cbxExBlockSize.Name = "cbxExBlockSize";
            this.cbxExBlockSize.Size = new System.Drawing.Size(76, 21);
            this.cbxExBlockSize.TabIndex = 2;
            this.cbxExBlockSize.Text = "KB";
            // 
            // cbxExPointerSize
            // 
            this.cbxExPointerSize.FormattingEnabled = true;
            this.cbxExPointerSize.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxExPointerSize.Location = new System.Drawing.Point(176, 53);
            this.cbxExPointerSize.Name = "cbxExPointerSize";
            this.cbxExPointerSize.Size = new System.Drawing.Size(76, 21);
            this.cbxExPointerSize.TabIndex = 2;
            this.cbxExPointerSize.Text = "B";
            // 
            // cbxExFileLength
            // 
            this.cbxExFileLength.FormattingEnabled = true;
            this.cbxExFileLength.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxExFileLength.Location = new System.Drawing.Point(176, 74);
            this.cbxExFileLength.Name = "cbxExFileLength";
            this.cbxExFileLength.Size = new System.Drawing.Size(76, 21);
            this.cbxExFileLength.TabIndex = 2;
            this.cbxExFileLength.Text = "MB";
            // 
            // cbxExX
            // 
            this.cbxExX.FormattingEnabled = true;
            this.cbxExX.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxExX.Location = new System.Drawing.Point(176, 112);
            this.cbxExX.Name = "cbxExX";
            this.cbxExX.Size = new System.Drawing.Size(76, 21);
            this.cbxExX.TabIndex = 2;
            this.cbxExX.Text = "MB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(32, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "X";
            // 
            // frmLinkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 437);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLinkList";
            this.Text = "Link List Allocation";
            this.Load += new System.EventHandler(this.frmLinkList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView History;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxX;
        private System.Windows.Forms.ComboBox cbxFileLength;
        private System.Windows.Forms.ComboBox cbxPointerSize;
        private System.Windows.Forms.ComboBox cbxBlockSize;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtFileLength;
        private System.Windows.Forms.TextBox txtPointerSize;
        private System.Windows.Forms.TextBox txtBlockSize;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxExX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxExFileLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxExPointerSize;
        private System.Windows.Forms.TextBox txtExBlockSize;
        private System.Windows.Forms.ComboBox cbxExBlockSize;
        private System.Windows.Forms.TextBox txtExPointerSize;
        private System.Windows.Forms.TextBox txtExX;
        private System.Windows.Forms.TextBox txtExFileLength;
    }
}