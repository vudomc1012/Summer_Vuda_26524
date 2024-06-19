using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.AbstractClass
{
    public abstract class SanPham
    {
        public string Ten { get; set; }
        public decimal GiaGoc { get; set; }
        public int SoLuong { get; set; }

        public SanPham(string ten, decimal giaGoc, int soLuong)
        {
            Ten = ten;
            GiaGoc = giaGoc;
            SoLuong = soLuong;
        }

        public abstract decimal TinhGiaBan();

        public abstract string LayThongTinSanPham();
    }
}
