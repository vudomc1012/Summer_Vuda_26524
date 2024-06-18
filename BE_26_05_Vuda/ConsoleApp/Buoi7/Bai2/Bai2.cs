using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp.Buoi7.Bai2
{
    public class Bai2
    {
        public void bai2()
        {
            QuanLySanPham quanLySanPham = new QuanLySanPham();

            DienThoai dienThoai = new DienThoai("iPhone 13", 20000000, 10, "Apple", "2021");
            Laptop laptop = new Laptop("Dell XPS 13", 30000000, 5, "Dell", "Core i7, 16GB RAM, 512GB SSD");
            Sach sach = new Sach("Lập trình C#", 200000, 20, "Nguyễn Văn A", "Giáo trình");

            quanLySanPham.ThemSanPham(dienThoai);
            quanLySanPham.ThemSanPham(laptop);
            quanLySanPham.ThemSanPham(sach);

            Console.WriteLine("Thông tin các sản phẩm:");
            quanLySanPham.HienThiThongTinSanPham();

            Console.WriteLine($"Tổng giá trị các sản phẩm: {quanLySanPham.TinhTongGiaTriSanPham()} VND");
        }
    }
}
