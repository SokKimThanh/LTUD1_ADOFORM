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
        DanhMucController controller = new DanhMucController();

        public FormDanhMuc()
        {
            InitializeComponent();
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Insert(new DanhMuc(ma.Text, ten.Text, ghichu.Text));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
