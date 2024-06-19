using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp.Buoi7.Bai3
{
    public class Bai3
    {
        public void bai3()
        {
            var nhapChu = new Common.ValidateData();
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();

            while (true)
            {
                Console.WriteLine("Chọn loại nhân viên để thêm:");
                Console.WriteLine("1. Nhân viên toàn thời gian");
                Console.WriteLine("2. Nhân viên bán thời gian");
                Console.WriteLine("3. Nhân viên thực tập");
                Console.WriteLine("4. Hiển thị thông tin nhân viên");
                Console.WriteLine("5. Tính tổng lương nhân viên");
                Console.WriteLine("6. Thoát");

                int luaChon;
                if (!int.TryParse(Console.ReadLine(), out luaChon) || luaChon < 1 || luaChon > 6)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    continue;
                }

                if (luaChon == 6)
                {
                    break;
                }

                if (luaChon == 4)
                {
                    quanLyNhanVien.HienThiThongTinNhanVien();
                    continue;
                }

                if (luaChon == 5)
                {
                    Console.WriteLine($"Tổng lương các nhân viên: {quanLyNhanVien.TinhTongLuongNhanVien()} VND");
                    continue;
                }

                Console.WriteLine("Nhập họ tên:");
                string hoTen = Console.ReadLine();
                
                if (!nhapChu.NhapChu(hoTen))
                {
                    Console.WriteLine("Tên không hợp lệ. Vui lòng không nhập số.");
                    continue;
                }

                Console.WriteLine("Nhập tuổi:");
                int tuoi;
                if (!int.TryParse(Console.ReadLine(), out tuoi))
                {
                    Console.WriteLine("Tuổi không hợp lệ.");
                    continue;
                }

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("Nhập lương cơ bản:");
                        decimal luongCoBan;
                        if (!decimal.TryParse(Console.ReadLine(), out luongCoBan))
                        {
                            Console.WriteLine("Lương cơ bản không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập thưởng:");
                        decimal thuong;
                        if (!decimal.TryParse(Console.ReadLine(), out thuong))
                        {
                            Console.WriteLine("Thưởng không hợp lệ.");
                            continue;
                        }

                        NhanVienToanThoiGian nvToanThoiGian = new NhanVienToanThoiGian(hoTen, tuoi, luongCoBan, thuong);
                        quanLyNhanVien.ThemNhanVien(nvToanThoiGian);
                        break;
                    case 2:
                        Console.WriteLine("Nhập lương theo giờ:");
                        decimal luongTheoGio;
                        if (!decimal.TryParse(Console.ReadLine(), out luongTheoGio))
                        {
                            Console.WriteLine("Lương theo giờ không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập số giờ làm việc:");
                        int soGioLamViec;
                        if (!int.TryParse(Console.ReadLine(), out soGioLamViec))
                        {
                            Console.WriteLine("Số giờ làm việc không hợp lệ.");
                            continue;
                        }

                        NhanVienBanThoiGian nvBanThoiGian = new NhanVienBanThoiGian(hoTen, tuoi, luongTheoGio, soGioLamViec);
                        quanLyNhanVien.ThemNhanVien(nvBanThoiGian);
                        break;
                    case 3:
                        Console.WriteLine("Nhập phụ cấp:");
                        decimal phuCap;
                        if (!decimal.TryParse(Console.ReadLine(), out phuCap))
                        {
                            Console.WriteLine("Phụ cấp không hợp lệ.");
                            continue;
                        }

                        NhanVienThucTap nvThucTap = new NhanVienThucTap(hoTen, tuoi, phuCap);
                        quanLyNhanVien.ThemNhanVien(nvThucTap);
                        break;
                }
            }
        }
    }
}
