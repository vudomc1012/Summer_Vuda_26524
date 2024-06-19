using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_26_05_Vuda.OOP.Buoi7.AbstractClass;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai2
{
    public class DienThoai : SanPham
    {
        public string HangSanXuat { get; set; }
        public string MauMa { get; set; }

        public DienThoai(string ten, decimal giaGoc, int soLuong, string hangSanXuat, string mauMa)
            : base(ten, giaGoc, soLuong)
        {
            HangSanXuat = hangSanXuat;
            MauMa = mauMa;
        }

        public override decimal TinhGiaBan()
        {
            // Giả sử giá bán bằng giá gốc
            return GiaGoc;
        }

        public override string LayThongTinSanPham()
        {
            return $"Điện thoại: {Ten}, Hãng sản xuất: {HangSanXuat}, Mẫu mã: {MauMa}, Giá: {GiaGoc}, Số lượng: {SoLuong}";
        }
    }
}
