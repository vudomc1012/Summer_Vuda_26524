using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.DataAccess.DTO
{
    public class NhanVien
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public double LuongCoBan { get; set; }
        public double HeSoLuong { get; set; }
        public double PhuCap { get; set; }
        public double TongLuong => LuongCoBan * HeSoLuong + PhuCap;

        public List<CongDoan> CongDoans { get; set; }

        public NhanVien()
        {
            CongDoans = new List<CongDoan>();
        }

        public static NhanVien TaoNhanVien(int id, string ten, string gioiTinh, int tuoi, double luongCoBan, double heSoLuong, double phuCap)
        {
            NhanVien nhanVien = new NhanVien
            {
                Id = id,
                Ten = ten,
                GioiTinh = gioiTinh,
                Tuoi = tuoi,
                LuongCoBan = luongCoBan,
                HeSoLuong = heSoLuong,
                PhuCap = phuCap
            };
            return nhanVien;
        }
    }

}
