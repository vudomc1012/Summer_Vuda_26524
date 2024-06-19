using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_26_05_Vuda.OOP.Buoi7.AbstractClass;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai2
{
    public class Sach : SanPham
    {
        public string TacGia { get; set; }
        public string TheLoai { get; set; }

        public Sach(string ten, decimal giaGoc, int soLuong, string tacGia, string theLoai)
            : base(ten, giaGoc, soLuong)
        {
            TacGia = tacGia;
            TheLoai = theLoai;
        }

        public override decimal TinhGiaBan()
        {
            // Giả sử giá bán bằng giá gốc
            return GiaGoc;
        }

        public override string LayThongTinSanPham()
        {
            return $"Sách: {Ten}, Tác giả: {TacGia}, Thể loại: {TheLoai}, Giá: {GiaGoc}, Số lượng: {SoLuong}";
        }
    }
}
