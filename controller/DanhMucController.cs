using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm
{
    internal class DanhMucController : DBConfig, DBController
    {
        SqlConnection conn = null;
        DataTable listgridview;
        SqlDataAdapter adapter;
        SqlCommand sqlcmd;

        public DataTable ListGridView { get => listgridview; set => listgridview = value; }

        public DanhMucController()
        {
            // Mở kết nối
            conn = GetConnection();
            ListGridView = new DataTable();
        }
        public bool Insert(object sender)
        {
            DanhMuc danhmuc = (DanhMuc)sender;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                // kiem tra trùng mã
                DataTable s = SelectOne(danhmuc.Ma);
                if (s.Rows.Count > 0)
                {
                    throw new Exception("trung id");
                }



                // Thực thi câu lệnh
                cmd.Connection = conn;
                cmd.CommandText = "sp_danhmuc_insert";
                cmd.CommandType = CommandType.StoredProcedure;
                // tham so
                SqlParameter ma = new SqlParameter("@ma", danhmuc.Ma);
                SqlParameter ten = new SqlParameter("@ten", danhmuc.Ten);
                SqlParameter ghichu = new SqlParameter("@ghichu", danhmuc.Ghichu);

                cmd.Parameters.Add(ma);
                cmd.Parameters.Add(ten);
                cmd.Parameters.Add(ghichu);
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
                sqlcmd.CommandText = "sp_danhmuc_select";
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
                sqlcmd.CommandText = "sp_danhmuc_selectone";
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
