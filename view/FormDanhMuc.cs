using ADOForm.Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm.view
{
    public partial class FormDanhMuc : Form
    {
        private DanhMucController controller;

        public FormDanhMuc()
        {
            InitializeComponent();
            controller = new DanhMucController(Utils.ConnectionString);
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            try
            {
                controller.SelectAll();
                dataGridView1.DataSource = controller.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Insert(new DanhMuc(ma.Text, ten.Text, ghichu.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
