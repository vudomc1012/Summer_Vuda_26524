using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_26_05_Vuda.ConsoleApp.Buoi7.AbstractClass;

namespace BE_26_05_Vuda.ConsoleApp.Buoi7.Bai2
{
    public class QuanLySanPham
    {
        private List<SanPham> danhSachSanPham = new List<SanPham>();

        public void ThemSanPham(SanPham sanPham)
        {
            danhSachSanPham.Add(sanPham);
        }

        public void HienThiThongTinSanPham()
        {
            foreach (var sanPham in danhSachSanPham)
            {
                Console.WriteLine(sanPham.LayThongTinSanPham());
            }
        }

        public decimal TinhTongGiaTriSanPham()
        {
            decimal tongGiaTri = 0;
            foreach (var sanPham in danhSachSanPham)
            {
                tongGiaTri += sanPham.TinhGiaBan() * sanPham.SoLuong;
            }
            return tongGiaTri;
        }
    }
}
