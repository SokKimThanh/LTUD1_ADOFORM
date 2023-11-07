using System.Collections;
using System.Data;
using System.Data.SqlClient;
using ADOForm.Connection;
using ADOForm.model;

namespace ADOForm
{
    public partial class ListSanPham : Form
    {

        SanPhamController CtrlSanpham;
        //DanhMucController CtrlDanhmuc;
        //NhaCungCapController CtrlNhacungcap;
        public ListSanPham()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DanhMuc dm = (DanhMuc)danhmuc.SelectedItem;
            //    NhaCungCap ncc = (NhaCungCap)nhacungcap.SelectedItem;
            //    SanPham sp = new SanPham(ma.Text, ten.Text, (double)gia.Value, (int)soluong.Value, dm, ncc);
            //    if ((bool)CtrlSanpham.Insert(sp))
            //    {
            //        MessageBox.Show("Thêm thành công");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CtrlSanpham = new SanPhamController(Utils.ConnectionString);
            // danh sach san pham
            CtrlSanpham.SelectAll();
            dgvSanPham.DataSource = CtrlSanpham.Listgridview;
            // cbo danh muc
            //danhmuc.DataSource = CtrlDanhmuc.SelectAll();
            //danhmuc.DisplayMember = "ten";
            //danhmuc.ValueMember = "ma";
            //danhmuc.SelectedIndex = 0;

            //cbo nha cung cap
            //nhacungcap.DataSource = CtrlNhacungcap.SelectAll();
            //danhmuc.DisplayMember = "ten";
            //danhmuc.ValueMember = "ma";
            //danhmuc.SelectedIndex = 0;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}