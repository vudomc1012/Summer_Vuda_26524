using BE_26_05_Vuda.OOP.Buoi7.AbstractClass;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai3
{
    public class NhanVienThucTap : NhanVien
    {
        public decimal PhuCap { get; set; }

        public NhanVienThucTap(string hoTen, int tuoi, decimal phuCap)
            : base(hoTen, tuoi)
        {
            PhuCap = phuCap;
        }

        public override decimal TinhLuong()
        {
            return PhuCap;
        }

        public override string LayThongTinNhanVien()
        {
            return $"Nhân viên thực tập: {HoTen}, Tuổi: {Tuoi}, Lương: {TinhLuong()}";
        }
    }
}
