using System.Collections;
using System.Data;
using System.Data.SqlClient;
using ADOForm.model;

namespace ADOForm
{
    public partial class ListSanPham : Form
    {
        List<SanPham> list = new List<SanPham>();
        SanPhamController CtrlSanpham;
        DanhMucController CtrlDanhmuc;
        NhaCungCapController CtrlNhacungcap;
        public ListSanPham()
        {
            InitializeComponent();
            CtrlSanpham = new SanPhamController();
            CtrlDanhmuc = new DanhMucController();
            CtrlNhacungcap = new NhaCungCapController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DanhMuc dm = (DanhMuc)danhmuc.SelectedItem;
                NhaCungCap ncc = (NhaCungCap)nhacungcap.SelectedItem;
                SanPham sp = new SanPham(ma.Text, ten.Text, (double)gia.Value, (int)soluong.Value, dm, ncc);
                if ((bool)CtrlSanpham.Insert(sp))
                {
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // danh sach san pham
            dgvSanPham.DataSource = CtrlSanpham.Select();

            // cbo danh muc
            danhmuc.DataSource = CtrlDanhmuc.Select();
            danhmuc.DisplayMember = "ten";
            danhmuc.ValueMember = "ma";
            danhmuc.SelectedIndex = 0;

            //cbo nha cung cap
            nhacungcap.DataSource = CtrlNhacungcap.Select();
            danhmuc.DisplayMember = "ten";
            danhmuc.ValueMember = "ma";
            danhmuc.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}