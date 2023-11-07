using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOForm
{
    internal class SanPham
    {
        private string ma, ten;
        private double gia;
        private int soluong;
        private DanhMuc danhmuc;
        private NhaCungCap nhacungcap;

        public SanPham()
        {
        }

        public SanPham(string ma, string ten, double gia = 0, int soluong = 0, DanhMuc danhmuc = null, NhaCungCap nhacungcap = null)
        {
            //if (ma.Length != 10)
            //{
            //    throw new Exception("ma khong hop le");
            //}
            if (ten.Length > 256)
            {
                throw new Exception("ten khong hop le");
            }
            this.ma = ma;
            this.ten = ten;
            this.gia = gia;
            this.soluong = soluong;
            this.danhmuc = danhmuc;
            this.nhacungcap = nhacungcap;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public double Gia { get => gia; set => gia = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        internal DanhMuc Danhmuc { get => danhmuc; set => danhmuc = value; }
        internal NhaCungCap Nhacungcap { get => nhacungcap; set => nhacungcap = value; }

        public override string ToString()
        {
            return $"{this.ma,-10}{this.ten,-10}{this.gia,-10}{this.soluong,-10}{this.danhmuc.ToString(),-10}{this.nhacungcap.ToString(),-10}";
        }
    }
}
