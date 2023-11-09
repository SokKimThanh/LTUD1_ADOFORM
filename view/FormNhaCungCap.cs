using ADOForm.controller;
using System.Xml.Linq;

namespace ADOForm.view
{
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapController controller;
        public FormNhaCungCap()
        {
            InitializeComponent();
            controller = new NhaCungCapController(Connection.Utils.ConnectionString);
            dgvNhaCungCap.ReadOnly = true; //Tất cả các cell không thể sửa
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            try
            {
                controller.SelectAll();
                dgvNhaCungCap.DataSource = controller.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap(txtMa.Text, txtTen.Text, txtGhiChu.Text);
                controller.Insert(ncc);

                controller.SelectAll();
                dgvNhaCungCap.DataSource = controller.DataSource;//refresh trang
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
                dgvNhaCungCap.DataSource = controller.DataSource;//refresh trang
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap ncc = new NhaCungCap(txtMa.Text, txtTen.Text, txtGhiChu.Text);

                controller.Update(ncc);

                controller.SelectAll();
                dgvNhaCungCap.DataSource = controller.DataSource;//refresh trang
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNhaCungCap_Click(object sender, EventArgs e)
        {


        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Lấy dòng được chọn
                    DataGridViewRow row = this.dgvNhaCungCap.Rows[e.RowIndex];

                    // Hiển thị thông tin lên các TextBox
                    txtMa.Text = row.Cells["ma"].Value.ToString();
                    txtTen.Text = row.Cells["ten"].Value.ToString();
                    txtGhiChu.Text = row.Cells["ghichu"].Value.ToString();
                    // ...
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
