namespace ADOForm
{
    partial class ListSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSanPham = new DataGridView();
            btnxoa = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cbonhacungcap = new ComboBox();
            label5 = new Label();
            cbodanhmuc = new ComboBox();
            txtSoLuong = new NumericUpDown();
            label4 = new Label();
            txtDonGia = new NumericUpDown();
            label3 = new Label();
            txtTenSP = new TextBox();
            label2 = new Label();
            txtMaSP = new TextBox();
            label6 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnadd = new Button();
            btnsua = new Button();
            btnexit = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDonGia).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(3, 22);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvSanPham.RowTemplate.Height = 28;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(607, 394);
            dgvSanPham.TabIndex = 5;
            dgvSanPham.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnxoa
            // 
            btnxoa.Dock = DockStyle.Fill;
            btnxoa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoa.Location = new Point(75, 3);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(66, 87);
            btnxoa.TabIndex = 0;
            btnxoa.Text = "xoa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += Insert_click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.5882339F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117661F));
            tableLayoutPanel1.Size = new Size(302, 419);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(296, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.6860466F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.31395F));
            tableLayoutPanel2.Controls.Add(cbonhacungcap, 1, 5);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(cbodanhmuc, 1, 4);
            tableLayoutPanel2.Controls.Add(txtSoLuong, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 3);
            tableLayoutPanel2.Controls.Add(txtDonGia, 1, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txtTenSP, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(txtMaSP, 1, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 22);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(290, 264);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cbonhacungcap
            // 
            cbonhacungcap.Dock = DockStyle.Fill;
            cbonhacungcap.FormattingEnabled = true;
            cbonhacungcap.Location = new Point(94, 223);
            cbonhacungcap.Name = "cbonhacungcap";
            cbonhacungcap.Size = new Size(193, 27);
            cbonhacungcap.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 176);
            label5.Name = "label5";
            label5.Size = new Size(85, 44);
            label5.TabIndex = 14;
            label5.Text = "Danh mục";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbodanhmuc
            // 
            cbodanhmuc.Dock = DockStyle.Fill;
            cbodanhmuc.FormattingEnabled = true;
            cbodanhmuc.Location = new Point(94, 179);
            cbodanhmuc.Name = "cbodanhmuc";
            cbodanhmuc.Size = new Size(193, 27);
            cbodanhmuc.TabIndex = 10;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Fill;
            txtSoLuong.Location = new Point(94, 135);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(193, 26);
            txtSoLuong.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 132);
            label4.Name = "label4";
            label4.Size = new Size(85, 44);
            label4.TabIndex = 15;
            label4.Text = "Số lượng";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDonGia
            // 
            txtDonGia.Dock = DockStyle.Fill;
            txtDonGia.Location = new Point(94, 91);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(193, 26);
            txtDonGia.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(85, 44);
            label3.TabIndex = 16;
            label3.Text = "Đơn giá";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTenSP
            // 
            txtTenSP.Dock = DockStyle.Fill;
            txtTenSP.Location = new Point(94, 47);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(193, 26);
            txtTenSP.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(85, 44);
            label2.TabIndex = 17;
            label2.Text = "Tên";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMaSP
            // 
            txtMaSP.Dock = DockStyle.Fill;
            txtMaSP.Location = new Point(94, 3);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(193, 26);
            txtMaSP.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 220);
            label6.Name = "label6";
            label6.Size = new Size(85, 44);
            label6.TabIndex = 13;
            label6.Text = "Nhà cung cấp";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 44);
            label1.TabIndex = 18;
            label1.Text = "Mã";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(296, 118);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác thông tin";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnadd, 0, 0);
            tableLayoutPanel3.Controls.Add(btnxoa, 1, 0);
            tableLayoutPanel3.Controls.Add(btnsua, 2, 0);
            tableLayoutPanel3.Controls.Add(btnexit, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 22);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(290, 93);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // btnadd
            // 
            btnadd.Dock = DockStyle.Fill;
            btnadd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnadd.Location = new Point(3, 3);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(66, 87);
            btnadd.TabIndex = 0;
            btnadd.Text = "add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += Insert_click;
            // 
            // btnsua
            // 
            btnsua.Dock = DockStyle.Fill;
            btnsua.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsua.Location = new Point(147, 3);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(66, 87);
            btnsua.TabIndex = 0;
            btnsua.Text = "sua";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += Insert_click;
            // 
            // btnexit
            // 
            btnexit.Dock = DockStyle.Fill;
            btnexit.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnexit.Location = new Point(219, 3);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(68, 87);
            btnexit.TabIndex = 0;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += Insert_click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(927, 425);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSanPham);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(311, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(613, 419);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hiển thị danh sách thông tin";
            // 
            // ListSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 425);
            Controls.Add(tableLayoutPanel4);
            Name = "ListSanPham";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách sản phẩm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDonGia).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvSanPham;
        private Button btnxoa;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private ComboBox cbonhacungcap;
        private Label label5;
        private ComboBox cbodanhmuc;
        private NumericUpDown txtSoLuong;
        private Label label4;
        private NumericUpDown txtDonGia;
        private Label label3;
        private TextBox txtTenSP;
        private Label label2;
        private TextBox txtMaSP;
        private Label label6;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnsua;
        private Button btnexit;
        private Button btnadd;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox3;
    }
}