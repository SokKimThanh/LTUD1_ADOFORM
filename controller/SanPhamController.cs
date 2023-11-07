using ADOForm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using ADOForm.Connection;
using ADOForm.model;

namespace ADOForm
{
    internal class SanPhamController : MyController
    {

        DanhMucController danhmucCtrl;
        NhaCungCapController nhacungcapCtrl;

        public SanPhamController(string connectionString) : base(connectionString)
        {
            danhmucCtrl = new DanhMucController(connectionString);
            nhacungcapCtrl = new NhaCungCapController(connectionString);
        }



        public override void Insert(object sender)
        {
            SanPham sanpham = (SanPham)sender;
            try
            {
                SqlConnection conn = OpenConnection();

                //================================================== 
                // Thực hiện các thao tác trên cơ sở dữ liệu tại đây
                //==================================================
                DataRowCollection dmOne = danhmucCtrl.SelectByID(sanpham.Danhmuc.Ma).Rows;
                DataRowCollection nccOne = nhacungcapCtrl.SelectByID(sanpham.Nhacungcap.Ma).Rows;


                // Thực thi câu lệnh
                Sql.Connection = conn;
                Sql.CommandText = "sp_sanpham_insert";
                Sql.CommandType = CommandType.StoredProcedure;
                // tham so
                SqlParameter ma = new SqlParameter("@ma", sanpham.Ma);
                SqlParameter ten = new SqlParameter("@ten", sanpham.Ten);
                SqlParameter gia = new SqlParameter("@ten", sanpham.Ten);
                SqlParameter soluong = new SqlParameter("@soluong", sanpham.Soluong);
                SqlParameter ncc = new SqlParameter("@nhacungcap", nccOne[0].Table.Columns[0]/* ma nha cung cap */.ColumnName);
                SqlParameter dm = new SqlParameter("@danhmuc", dmOne[0].Table.Columns[0]/* ma danh muc */.ColumnName);
                Sql.Parameters.Add(ma);
                Sql.Parameters.Add(ten);
                Sql.Parameters.Add(gia);
                Sql.Parameters.Add(soluong);
                Sql.Parameters.Add(ncc);
                Sql.Parameters.Add(dm);
                int result = Sql.ExecuteNonQuery();
                // kiem tra thuc thi cau lenhsql
                if (result == 0)
                {
                    MessageBox.Show("Thêm không thành công");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                CloseConnection();
            }
        }

        public override void SelectAll()
        {

            try
            {
                SqlConnection conn = OpenConnection();
                // thực thi câu lệnh
                Sql = new SqlCommand();
                Sql.Connection = conn;
                Sql.CommandText = "sp_sanpham_select_all";
                Sql.CommandType = CommandType.StoredProcedure;
                Adapter = new SqlDataAdapter(Sql);
                Adapter.Fill(Listgridview);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }

        public override DataTable SelectByID(object id)
        {
            try
            {
                // Mở kết nối
                SqlConnection conn = OpenConnection();
                Sql = new SqlCommand();
                Sql.Connection = conn;
                Sql.CommandText = "sp_sanpham_selectone";
                Sql.CommandType = CommandType.StoredProcedure;
                Adapter = new SqlDataAdapter(Sql);
                Adapter.Fill(Listgridview);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return Listgridview;
        }

        public override void Update(object sender)
        {
            try
            {
                // Mở kết nối
                SanPham sanpham = (SanPham)sender;

                // Mở kết nối
                SqlConnection conn = OpenConnection();

                // Tạo một đối tượng SqlCommand
                Sql = new SqlCommand("sp_sanpham_update", conn);
                Sql.CommandType = CommandType.StoredProcedure;

                // Thêm tham số vào SqlCommand
                Sql.Parameters.AddWithValue("@ma", sanpham.Ma);
                Sql.Parameters.AddWithValue("@ten", sanpham.Ten);
                Sql.Parameters.AddWithValue("@gia", sanpham.Gia);
                Sql.Parameters.AddWithValue("@soluong", sanpham.Soluong);
                Sql.Parameters.AddWithValue("@danhmuc", sanpham.Danhmuc);
                Sql.Parameters.AddWithValue("@nhacungcap", sanpham.Nhacungcap);

                // Thực thi SqlCommand
                Sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public override void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}
