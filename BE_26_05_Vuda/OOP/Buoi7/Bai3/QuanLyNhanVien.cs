using BE_26_05_Vuda.OOP.Buoi7.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai3
{
    public class QuanLyNhanVien
    {
        private List<NhanVien> danhSachNhanVien = new List<NhanVien>();

        public void ThemNhanVien(NhanVien nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
        }

        public void HienThiThongTinNhanVien()
        {
            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine(nhanVien.LayThongTinNhanVien());
            }
        }

        public decimal TinhTongLuongNhanVien()
        {
            decimal tongLuong = 0;
            foreach (var nhanVien in danhSachNhanVien)
            {
                tongLuong += nhanVien.TinhLuong();
            }
            return tongLuong;
        }
    }
}
