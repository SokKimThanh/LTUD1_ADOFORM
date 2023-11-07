using ADOForm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOForm
{
    internal class SanPhamController : DBConfig, DBController
    {
        SqlConnection conn = null;
        DataTable listgridview;
        SqlDataAdapter adapter;
        SqlCommand sqlcmd;

        DanhMucController danhmucCtrl;
        NhaCungCapController nhacungcapCtrl;

        public DataTable ListGridView { get => listgridview; set => listgridview = value; }

        public SanPhamController()
        {
            // Mở kết nối
            conn = GetConnection();
            danhmucCtrl = new DanhMucController();
            nhacungcapCtrl = new NhaCungCapController();
            ListGridView = new DataTable();
        }
        public bool Insert(object sender)
        {
            SanPham sanpham = (SanPham)sender;
            try
            {
                conn.Open();
                //======================================
                //          Thực thi lệnh sql
                //======================================
                DataRowCollection dmOne = danhmucCtrl.SelectOne(sanpham.Danhmuc.Ma).Rows;
                DataRowCollection nccOne = nhacungcapCtrl.SelectOne(sanpham.Nhacungcap.Ma).Rows;
                 

                SqlCommand cmd = new SqlCommand();
                // Thực thi câu lệnh
                cmd.Connection = conn;
                cmd.CommandText = "sp_sanpham_insert";
                cmd.CommandType = CommandType.StoredProcedure;
                // tham so
                SqlParameter ma = new SqlParameter("@ma", sanpham.Ma);
                SqlParameter ten = new SqlParameter("@ten", sanpham.Ten);
                SqlParameter gia = new SqlParameter("@ten", sanpham.Ten);
                SqlParameter soluong = new SqlParameter("@ten", sanpham.Ten);
                SqlParameter ncc = new SqlParameter("@nhacungcap", nccOne[0].Table.Columns[0]/* ma nha cung cap */.ColumnName);
                SqlParameter dm = new SqlParameter("@danhmuc", dmOne[0].Table.Columns[0]/* ma danh muc */.ColumnName);
                cmd.Parameters.Add(ma);
                cmd.Parameters.Add(ten);
                cmd.Parameters.Add(gia);
                cmd.Parameters.Add(soluong);
                cmd.Parameters.Add(ncc);
                cmd.Parameters.Add(dm);
                int result = cmd.ExecuteNonQuery();
                // kiem tra thuc thi cau lenhsql
                if (result == 0)
                {
                    MessageBox.Show("Them thanh cong");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return true;
        }
        public bool Update(object table_name)
        {
            throw new NotImplementedException();
        }
        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public DataTable Select()
        {

            try
            {
                // Mở kết nối
                conn.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = conn;
                sqlcmd.CommandText = "sp_sanpham_select";
                sqlcmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(listgridview);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return listgridview;
        }


        public DataTable SelectOne(object id)
        {
            try
            {
                // Mở kết nối
                conn.Open();
                sqlcmd = new SqlCommand();
                sqlcmd.Connection = conn;
                sqlcmd.CommandText = "sp_sanpham_selectone";
                sqlcmd.CommandType = CommandType.StoredProcedure;
                adapter = new SqlDataAdapter(sqlcmd);
                adapter.Fill(listgridview);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return listgridview;
        }


    }
}
