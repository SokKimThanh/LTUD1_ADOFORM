using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ADOForm.Connection;
using ADOForm.controller;
using ADOForm.model;
using Microsoft.VisualBasic.ApplicationServices;

namespace ADOForm
{
    public partial class ListSanPham : Form
    {

        SanPhamController csanpham;
        DanhMucController cdanhmuc;
        NhaCungCapController cnhacungcap;
        public ListSanPham()
        {
            InitializeComponent();
            csanpham = new SanPhamController(Utils.ConnectionString);
            cdanhmuc = new DanhMucController(Utils.ConnectionString);
            cnhacungcap = new NhaCungCapController(Utils.ConnectionString);
        }


        private void Insert_click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dòng đầu tiên từ DataTable 
                DanhMuc dm = (DanhMuc)cdanhmuc.FromDataRow(cdanhmuc.SelectByID(cbodanhmuc.SelectedValue).Rows[0]);// Chuyển đổi DataRow thành DanhMuc

                // Lấy dòng đầu tiên từ DataTable 
                NhaCungCap ncc = (NhaCungCap)cnhacungcap.FromDataRow(cnhacungcap.SelectByID(cbonhacungcap.SelectedValue).Rows[0]);// Chuyển đổi DataRow thành DanhMuc

                SanPham sp = new SanPham(
                    txtMaSP.Text,
                    txtTenSP.Text,
                    (double)txtDonGia.Value,
                    (int)txtSoLuong.Value,
                    dm,
                    ncc);
                csanpham.Insert(sp);
                //refresh trang
                csanpham.SelectAll();
                dgvSanPham.DataSource = csanpham.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // danh sach san pham
                csanpham.SelectAll();
                dgvSanPham.DataSource = csanpham.DataSource;

                // cbo danh muc
                cdanhmuc.SelectAll();
                cbodanhmuc.DataSource = cdanhmuc.DataSource;
                cbodanhmuc.DisplayMember = "ten";
                cbodanhmuc.ValueMember = "ma";
                cbodanhmuc.SelectedIndex = 0;

                //cbo nha cung cap
                cnhacungcap.SelectAll();
                cbonhacungcap.DataSource = cnhacungcap.DataSource;
                cbonhacungcap.DisplayMember = "ten";
                cbonhacungcap.ValueMember = "ma";
                cbonhacungcap.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}