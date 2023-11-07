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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // ten
            // 
            ten.Location = new Point(286, 87);
            ten.Name = "ten";
            ten.Size = new Size(100, 23);
            ten.TabIndex = 2;
            // 
            // ma
            // 
            ma.Location = new Point(286, 37);
            ma.Name = "ma";
            ma.Size = new Size(100, 23);
            ma.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(286, 181);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ghichu
            // 
            ghichu.Location = new Point(407, 37);
            ghichu.Name = "ghichu";
            ghichu.Size = new Size(100, 96);
            ghichu.TabIndex = 5;
            ghichu.Text = "";
            // 
            // FormDanhMuc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ghichu);
            Controls.Add(button1);
            Controls.Add(ma);
            Controls.Add(ten);
            Controls.Add(dataGridView1);
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
    }
}