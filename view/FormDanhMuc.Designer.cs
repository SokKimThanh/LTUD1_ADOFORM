namespace ADOForm.view
{
    partial class FormDanhMuc
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
            dataGridView1 = new DataGridView();
            ten = new TextBox();
            ma = new TextBox();
            button1 = new Button();
            ghichu = new RichTextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(257, 13);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 544);
            dataGridView1.TabIndex = 0;
            // 
            // ten
            // 
            ten.Location = new Point(12, 47);
            ten.Margin = new Padding(3, 4, 3, 4);
            ten.Name = "ten";
            ten.Size = new Size(228, 26);
            ten.TabIndex = 2;
            // 
            // ma
            // 
            ma.Location = new Point(12, 13);
            ma.Margin = new Padding(3, 4, 3, 4);
            ma.Name = "ma";
            ma.Size = new Size(228, 26);
            ma.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 528);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnInsert_Click;
            // 
            // ghichu
            // 
            ghichu.Location = new Point(12, 81);
            ghichu.Margin = new Padding(3, 4, 3, 4);
            ghichu.Name = "ghichu";
            ghichu.Size = new Size(228, 439);
            ghichu.TabIndex = 5;
            ghichu.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(154, 528);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 4;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnInsert_Click;
            // 
            // FormDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 570);
            Controls.Add(ghichu);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ma);
            Controls.Add(ten);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDanhMuc";
            Text = "FormDanhMuc";
            Load += FormDanhMuc_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox ten;
        private TextBox ma;
        private Button button1;
        private RichTextBox ghichu;
        private Button button2;
    }
}