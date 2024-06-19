using BE_26_05_Vuda.OOP.Buoi7.AbstractClass;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai3
{
    public class NhanVienToanThoiGian : NhanVien
    {

        public decimal LuongCoBan { get; set; }
        public decimal Thuong { get; set; }

        public NhanVienToanThoiGian(string hoTen, int tuoi, decimal luongCoBan, decimal thuong)
            : base(hoTen, tuoi)
        {
            LuongCoBan = luongCoBan;
            Thuong = thuong;
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan + Thuong;
        }

        public override string LayThongTinNhanVien()
        {
            return $"Nhân viên toàn thời gian: {HoTen}, Tuổi: {Tuoi}, Lương: {TinhLuong()}";
        }
    }
}
