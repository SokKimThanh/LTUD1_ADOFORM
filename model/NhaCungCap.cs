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
            if (ma.Length != 10)
            {
                throw new Exception("ma khong hop le");
            }
            if (ten.Length > 256)
            {
                throw new Exception("ten khong hop le");
            }
            this.ma = ma;
            this.ten = ten;
            this.ghichu = ghichu;
        }

        public string Ma
        {
            get => ma; set
            {
                if (ma.Length != 10)
                {
                    throw new Exception("ma khong hop le");
                }
                ma = value;
            }
        }
        public string Ten
        {
            get => ten; set
            {
                if (ten.Length > 256)
                {
                    throw new Exception("ten khong hop le");
                }
                ten = value;
            }
        }
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}
