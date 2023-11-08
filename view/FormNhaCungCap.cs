using ADOForm.controller;
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
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapController controller;
        public FormNhaCungCap()
        {
            InitializeComponent();
            controller = new NhaCungCapController(Connection.Utils.ConnectionString);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap(txtMa.Text, txtTen.Text, txtGhiChu.Text);
                controller.Insert(ncc);

                controller.SelectAll();
                dataGridView1.DataSource = controller.DataSource;//refresh trang
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Delete(txtMa.Text);

                controller.SelectAll();
                dataGridView1.DataSource = controller.DataSource;//refresh trang
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
