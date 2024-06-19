using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp.Buoi7.AbstractClass
{
    public abstract class NhanVien
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }

        public NhanVien(string hoTen, int tuoi)
        {
            HoTen = hoTen;
            Tuoi = tuoi;
        }

        public abstract decimal TinhLuong();

        public abstract string LayThongTinNhanVien();
    }
}
