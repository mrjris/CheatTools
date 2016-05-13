namespace CheatTool
{
    partial class frmAllocation1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxExFileLength = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxExX = new System.Windows.Forms.ComboBox();
            this.cbxExBlockSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExBlockSize = new System.Windows.Forms.TextBox();
            this.txtExCount = new System.Windows.Forms.TextBox();
            this.txtExFileLength = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxX = new System.Windows.Forms.ComboBox();
            this.txtBlockSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileLength = new System.Windows.Forms.TextBox();
            this.txtBlocks = new System.Windows.Forms.TextBox();
            this.cbxFileLength = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBlockSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.History = new System.Windows.Forms.ListView();
            this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Block_Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.extent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.block = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExStart);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.cbxExFileLength);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cbxExX);
            this.groupBox4.Controls.Add(this.cbxExBlockSize);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtExBlockSize);
            this.groupBox4.Controls.Add(this.txtExCount);
            this.groupBox4.Controls.Add(this.txtExFileLength);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(390, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 164);
            this.groupBox4.TabIndex = 102;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Extent Block";
            // 
            // btnExStart
            // 
            this.btnExStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExStart.Location = new System.Drawing.Point(3, 138);
            this.btnExStart.Name = "btnExStart";
            this.btnExStart.Size = new System.Drawing.Size(391, 23);
            this.btnExStart.TabIndex = 100;
            this.btnExStart.Text = "Start";
            this.btnExStart.UseVisualStyleBackColor = true;
            this.btnExStart.Click += new System.EventHandler(this.btnExStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Block size";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "2";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // cbxExFileLength
            // 
            this.cbxExFileLength.FormattingEnabled = true;
            this.cbxExFileLength.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxExFileLength.Location = new System.Drawing.Point(125, 50);
            this.cbxExFileLength.Name = "cbxExFileLength";
            this.cbxExFileLength.Size = new System.Drawing.Size(53, 21);
            this.cbxExFileLength.TabIndex = 2;
            this.cbxExFileLength.TabStop = false;
            this.cbxExFileLength.Text = "MB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Extent num";
            // 
            // cbxExX
            // 
            this.cbxExX.FormattingEnabled = true;
            this.cbxExX.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.cbxExX.Location = new System.Drawing.Point(340, 83);
            this.cbxExX.Name = "cbxExX";
            this.cbxExX.Size = new System.Drawing.Size(53, 21);
            this.cbxExX.TabIndex = 2;
            this.cbxExX.TabStop = false;
            this.cbxExX.Text = "MB";
            // 
            // cbxExBlockSize
            // 
            this.cbxExBlockSize.FormattingEnabled = true;
            this.cbxExBlockSize.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxExBlockSize.Location = new System.Drawing.Point(125, 16);
            this.cbxExBlockSize.Name = "cbxExBlockSize";
            this.cbxExBlockSize.Size = new System.Drawing.Size(53, 21);
            this.cbxExBlockSize.TabIndex = 2;
            this.cbxExBlockSize.TabStop = false;
            this.cbxExBlockSize.Text = "KB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "File length";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(288, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 55);
            this.label8.TabIndex = 1;
            this.label8.Text = "X";
            // 
            // txtExBlockSize
            // 
            this.txtExBlockSize.Location = new System.Drawing.Point(78, 16);
            this.txtExBlockSize.Name = "txtExBlockSize";
            this.txtExBlockSize.Size = new System.Drawing.Size(34, 20);
            this.txtExBlockSize.TabIndex = 0;
            this.txtExBlockSize.Text = "2";
            this.txtExBlockSize.TextChanged += new System.EventHandler(this.txtBlockSize_TextChanged);
            // 
            // txtExCount
            // 
            this.txtExCount.Location = new System.Drawing.Point(78, 83);
            this.txtExCount.Name = "txtExCount";
            this.txtExCount.Size = new System.Drawing.Size(100, 20);
            this.txtExCount.TabIndex = 0;
            this.txtExCount.Text = "100";
            this.toolTip1.SetToolTip(this.txtExCount, "Đề phải cho dữ liệu này. \r\nvd: extent has 100 blocks");
            // 
            // txtExFileLength
            // 
            this.txtExFileLength.Location = new System.Drawing.Point(78, 51);
            this.txtExFileLength.Name = "txtExFileLength";
            this.txtExFileLength.Size = new System.Drawing.Size(34, 20);
            this.txtExFileLength.TabIndex = 99;
            this.txtExFileLength.TabStop = false;
            this.txtExFileLength.Text = "25";
            this.toolTip1.SetToolTip(this.txtExFileLength, "Để File Length là số nguyên, để kiểu thực là lỗi.\r\nSo sánh (x < File Length)? \r\nĐ" +
        "úng thì OK\r\nSai thì error. \r\nBình thường là sẽ Đúng.");
            this.txtExFileLength.TextChanged += new System.EventHandler(this.txtFileLength_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtX);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Controls.Add(this.cbxX);
            this.groupBox3.Controls.Add(this.txtBlockSize);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtFileLength);
            this.groupBox3.Controls.Add(this.txtBlocks);
            this.groupBox3.Controls.Add(this.cbxFileLength);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbxBlockSize);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 164);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Block";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Block size";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(222, 83);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 1;
            this.txtX.Text = "1";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtX, "Nếu đề không cho đơn vị x là KB hay MB thì mặc định là B.\r\nKhi nhập, nhớ điều chỉ" +
        "nh.");
            this.txtX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtX_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStart.Location = new System.Drawing.Point(3, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(381, 23);
            this.btnStart.TabIndex = 100;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxX
            // 
            this.cbxX.FormattingEnabled = true;
            this.cbxX.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB",
            "GB"});
            this.cbxX.Location = new System.Drawing.Point(328, 83);
            this.cbxX.Name = "cbxX";
            this.cbxX.Size = new System.Drawing.Size(53, 21);
            this.cbxX.TabIndex = 2;
            this.cbxX.TabStop = false;
            this.cbxX.Text = "MB";
            // 
            // txtBlockSize
            // 
            this.txtBlockSize.Location = new System.Drawing.Point(78, 16);
            this.txtBlockSize.Name = "txtBlockSize";
            this.txtBlockSize.Size = new System.Drawing.Size(34, 20);
            this.txtBlockSize.TabIndex = 0;
            this.txtBlockSize.Text = "2";
            this.txtBlockSize.TextChanged += new System.EventHandler(this.txtBlockSize_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(276, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 55);
            this.label4.TabIndex = 1;
            this.label4.Text = "X";
            // 
            // txtFileLength
            // 
            this.txtFileLength.Location = new System.Drawing.Point(78, 51);
            this.txtFileLength.Name = "txtFileLength";
            this.txtFileLength.Size = new System.Drawing.Size(34, 20);
            this.txtFileLength.TabIndex = 99;
            this.txtFileLength.TabStop = false;
            this.txtFileLength.Text = "13";
            this.toolTip1.SetToolTip(this.txtFileLength, "Xét x < File Length ?\r\nĐúng thì OK\r\nSai thì error");
            this.txtFileLength.TextChanged += new System.EventHandler(this.txtFileLength_TextChanged);
            // 
            // txtBlocks
            // 
            this.txtBlocks.Location = new System.Drawing.Point(78, 83);
            this.txtBlocks.Name = "txtBlocks";
            this.txtBlocks.ReadOnly = true;
            this.txtBlocks.Size = new System.Drawing.Size(100, 20);
            this.txtBlocks.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtBlocks, "Blocks = File Length / Block size");
            // 
            // cbxFileLength
            // 
            this.cbxFileLength.FormattingEnabled = true;
            this.cbxFileLength.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxFileLength.Location = new System.Drawing.Point(125, 50);
            this.cbxFileLength.Name = "cbxFileLength";
            this.cbxFileLength.Size = new System.Drawing.Size(53, 21);
            this.cbxFileLength.TabIndex = 2;
            this.cbxFileLength.TabStop = false;
            this.cbxFileLength.Text = "MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File length";
            // 
            // cbxBlockSize
            // 
            this.cbxBlockSize.FormattingEnabled = true;
            this.cbxBlockSize.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.cbxBlockSize.Location = new System.Drawing.Point(125, 16);
            this.cbxBlockSize.Name = "cbxBlockSize";
            this.cbxBlockSize.Size = new System.Drawing.Size(53, 21);
            this.cbxBlockSize.TabIndex = 2;
            this.cbxBlockSize.TabStop = false;
            this.cbxBlockSize.Text = "KB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Blocks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.History);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 312);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "History";
            // 
            // History
            // 
            this.History.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.X,
            this.Block_Size,
            this.extent,
            this.block,
            this.offset,
            this.pos});
            this.History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History.Location = new System.Drawing.Point(3, 16);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(784, 293);
            this.History.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.History.TabIndex = 0;
            this.History.UseCompatibleStateImageBehavior = false;
            this.History.View = System.Windows.Forms.View.Details;
            // 
            // X
            // 
            this.X.Text = "X";
            this.X.Width = 134;
            // 
            // Block_Size
            // 
            this.Block_Size.Text = "Block_Size";
            this.Block_Size.Width = 119;
            // 
            // extent
            // 
            this.extent.Text = "extent number";
            this.extent.Width = 84;
            // 
            // block
            // 
            this.block.Text = "block";
            // 
            // offset
            // 
            this.offset.Text = "offset";
            // 
            // pos
            // 
            this.pos.Text = "location";
            this.pos.Width = 122;
            // 
            // frmAllocation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 495);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAllocation1";
            this.Text = "Contigous Allocation";
            this.Load += new System.EventHandler(this.frmAllocation1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView History;
        private System.Windows.Forms.ComboBox cbxFileLength;
        private System.Windows.Forms.ComboBox cbxBlockSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBlocks;
        private System.Windows.Forms.TextBox txtFileLength;
        private System.Windows.Forms.TextBox txtBlockSize;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnExStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxExFileLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxExX;
        private System.Windows.Forms.ComboBox cbxExBlockSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExBlockSize;
        private System.Windows.Forms.TextBox txtExCount;
        private System.Windows.Forms.TextBox txtExFileLength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader X;
        private System.Windows.Forms.ColumnHeader Block_Size;
        private System.Windows.Forms.ColumnHeader extent;
        private System.Windows.Forms.ColumnHeader block;
        private System.Windows.Forms.ColumnHeader offset;
        private System.Windows.Forms.ColumnHeader pos;
    }
}