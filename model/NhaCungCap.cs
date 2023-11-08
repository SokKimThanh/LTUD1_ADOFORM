using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm
{
    internal class NhaCungCap
    {
        private string ma, ten, ghichu;

        public NhaCungCap(string ma = "", string ten = "", string ghichu = "")
        {
            if (ma.Length == 0)
            {
                throw new Exception("mancc khong hop le");
            }
            if (ten.Length > 256 || ten.Length == 0)
            {
                throw new Exception("tennhacc khong hop le");
            }
            if (ghichu.Length > 256 || ghichu.Length == 0)
            {
                throw new Exception("ghichunhacc khong hop le");
            }
            this.ma = ma;
            this.ten = ten;
            this.ghichu = ghichu;
        }

        public string Ma
        {
            get => ma; set
            {
                //if (value.Length != 10)
                //{
                //    throw new Exception("mancc khong hop le");
                //}
                ma = value;
            }
        }
        public string Ten
        {
            get => ten; set
            {
                if (value.Length > 256)
                {
                    throw new Exception("tennhacc khong hop le");
                }
                ten = value;
            }
        }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
