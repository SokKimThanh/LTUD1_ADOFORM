using System.Data;
using System.Data.SqlClient;

namespace ADOForm
{
    internal class NhaCungCapController : DBConfig, DBController
    {
        SqlConnection conn = null;
        DataTable listgridview;
        SqlDataAdapter adapter;
        SqlCommand sqlcmd;

        DanhMucController danhmucCtrl;
        NhaCungCapController nhacungcapCtrl;

        public DataTable ListGridView { get => listgridview; set => listgridview = value; }

        public NhaCungCapController()
        {
            // Mở kết nối
            conn = GetConnection();
            danhmucCtrl = new DanhMucController();
            nhacungcapCtrl = new NhaCungCapController();
            ListGridView = new DataTable();
        }
        public bool Insert(object sender)
        {
            return false;
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
                sqlcmd.CommandText = "sp_nhacungcap_select";
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
                sqlcmd.CommandText = "sp_nhacungcap_selectone";
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