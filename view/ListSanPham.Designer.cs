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
            btnConnect = new Button();
            ma = new TextBox();
            ten = new TextBox();
            danhmuc = new ComboBox();
            nhacungcap = new ComboBox();
            gia = new NumericUpDown();
            soluong = new NumericUpDown();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)gia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soluong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.Location = new Point(12, 221);
            btnConnect.Margin = new Padding(3, 2, 3, 2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(65, 47);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "add";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += button1_Click;
            // 
            // ma
            // 
            ma.Location = new Point(108, 9);
            ma.Margin = new Padding(3, 2, 3, 2);
            ma.Name = "ma";
            ma.Size = new Size(175, 23);
            ma.TabIndex = 1;
            // 
            // ten
            // 
            ten.Location = new Point(108, 35);
            ten.Margin = new Padding(3, 2, 3, 2);
            ten.Name = "ten";
            ten.Size = new Size(175, 23);
            ten.TabIndex = 2;
            // 
            // danhmuc
            // 
            danhmuc.FormattingEnabled = true;
            danhmuc.Location = new Point(108, 137);
            danhmuc.Margin = new Padding(3, 2, 3, 2);
            danhmuc.Name = "danhmuc";
            danhmuc.Size = new Size(175, 23);
            danhmuc.TabIndex = 3;
            // 
            // nhacungcap
            // 
            nhacungcap.FormattingEnabled = true;
            nhacungcap.Location = new Point(108, 172);
            nhacungcap.Margin = new Padding(3, 2, 3, 2);
            nhacungcap.Name = "nhacungcap";
            nhacungcap.Size = new Size(175, 23);
            nhacungcap.TabIndex = 3;
            // 
            // gia
            // 
            gia.Location = new Point(108, 68);
            gia.Margin = new Padding(3, 2, 3, 2);
            gia.Name = "gia";
            gia.Size = new Size(174, 23);
            gia.TabIndex = 4;
            // 
            // soluong
            // 
            soluong.Location = new Point(108, 95);
            soluong.Margin = new Padding(3, 2, 3, 2);
            soluong.Name = "soluong";
            soluong.Size = new Size(174, 23);
            soluong.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(312, 0);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(291, 279);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(83, 221);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(65, 47);
            button1.TabIndex = 0;
            button1.Text = "xoa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(154, 221);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(65, 47);
            button2.TabIndex = 0;
            button2.Text = "sua";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(225, 221);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(65, 47);
            button3.TabIndex = 0;
            button3.Text = "exit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button1_Click;
            // 
            // ListSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 279);
            Controls.Add(dataGridView1);
            Controls.Add(soluong);
            Controls.Add(gia);
            Controls.Add(nhacungcap);
            Controls.Add(danhmuc);
            Controls.Add(ten);
            Controls.Add(ma);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnConnect);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ListSanPham";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gia).EndInit();
            ((System.ComponentModel.ISupportInitialize)soluong).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox ma;
        private TextBox ten;
        private ComboBox danhmuc;
        private ComboBox nhacungcap;
        private NumericUpDown gia;
        private NumericUpDown soluong;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}