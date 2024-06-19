using BE_26_05_Vuda.ConsoleApp.Buoi7.AbstractClass;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp.Buoi7.Bai3
{
    public class NhanVienBanThoiGian : NhanVien
    {
    public decimal LuongTheoGio { get; set; }
        public int SoGioLamViec { get; set; }

        public NhanVienBanThoiGian(string hoTen, int tuoi, decimal luongTheoGio, int soGioLamViec)
            : base(hoTen, tuoi)
        {
            LuongTheoGio = luongTheoGio;
            SoGioLamViec = soGioLamViec;
        }

        public override decimal TinhLuong()
        {
            return LuongTheoGio * SoGioLamViec;
        }

        public override string LayThongTinNhanVien()
        {
            return $"Nhân viên bán thời gian: {HoTen}, Tuổi: {Tuoi}, Lương: {TinhLuong()}";
        }
    }
}
