using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_26_05_Vuda.ConsoleApp.Buoi7.AbstractClass;

namespace BE_26_05_Vuda.ConsoleApp.Buoi7.Bai2
{
    public class Laptop : SanPham
    {
        public string HangSanXuat { get; set; }
        public string CauHinh { get; set; }

        public Laptop(string ten, decimal giaGoc, int soLuong, string hangSanXuat, string cauHinh)
            : base(ten, giaGoc, soLuong)
        {
            HangSanXuat = hangSanXuat;
            CauHinh = cauHinh;
        }

        public override decimal TinhGiaBan()
        {
            // Giả sử giá bán bằng giá gốc
            return GiaGoc;
        }

        public override string LayThongTinSanPham()
        {
            return $"Laptop: {Ten}, Hãng sản xuất: {HangSanXuat}, Cấu hình: {CauHinh}, Giá: {GiaGoc}, Số lượng: {SoLuong}";
        }
    }

}
