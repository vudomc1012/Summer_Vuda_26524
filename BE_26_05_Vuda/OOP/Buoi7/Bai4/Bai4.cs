﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BE_26_05_Vuda.OOP.Buoi7.DAL.Implement;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai4
{
    public class Bai4
    {
        public void bai4()
        {
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();

            while (true)
            {
                Console.WriteLine("Chọn chức năng:");
                Console.WriteLine("1. Thêm sinh viên từ bàn phím");
                Console.WriteLine("2. Thêm sinh viên từ file Excel");
                Console.WriteLine("3. Sắp xếp sinh viên");
                Console.WriteLine("4. Cập nhật thông tin sinh viên bởi ID");
                Console.WriteLine("5. Xóa sinh viên bởi ID");
                Console.WriteLine("6. Hiển thị danh sách sinh viên");
                Console.WriteLine("7. Thoát");

                int luaChon;
                if (!int.TryParse(Console.ReadLine(), out luaChon) || luaChon < 1 || luaChon > 7)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    continue;
                }

                if (luaChon == 7)
                {
                    break;
                }

                switch (luaChon)
                {
                    case 1:
                        Console.WriteLine("Nhập tên:");
                        string ten = Console.ReadLine();
                        if (!KiemTraChuoiKhongChuaSo(ten))
                        {
                            Console.WriteLine("Tên không hợp lệ. Vui lòng không nhập số.");
                            continue;
                        }

                        Console.WriteLine("Nhập giới tính:");
                        string gioiTinh = Console.ReadLine();

                        Console.WriteLine("Nhập tuổi:");
                        int tuoi;
                        if (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi <= 0)
                        {
                            Console.WriteLine("Tuổi không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập điểm Toán:");
                        double diemToan;
                        if (!double.TryParse(Console.ReadLine(), out diemToan) || diemToan < 0 || diemToan > 10)
                        {
                            Console.WriteLine("Điểm Toán không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập điểm Lý:");
                        double diemLy;
                        if (!double.TryParse(Console.ReadLine(), out diemLy) || diemLy < 0 || diemLy > 10)
                        {
                            Console.WriteLine("Điểm Lý không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập điểm Hóa:");
                        double diemHoa;
                        if (!double.TryParse(Console.ReadLine(), out diemHoa) || diemHoa < 0 || diemHoa > 10)
                        {
                            Console.WriteLine("Điểm Hóa không hợp lệ.");
                            continue;
                        }

                        SinhVien sv = new SinhVien(ten, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
                        quanLySinhVien.ThemSinhVien(sv);
                        break;

                    case 2:
                        Console.WriteLine("Nhập đường dẫn file Excel:");
                        string filePath = Console.ReadLine();
                        try
                        {
                            quanLySinhVien.ThemSinhVienTuExcel(filePath);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi khi đọc file Excel: {ex.Message}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Chọn tiêu chí sắp xếp (ten/hocLuc/diemTrungBinh):");
                        string tieuChi = Console.ReadLine();
                        quanLySinhVien.SapXepSinhVien(tieuChi);
                        break;

                    case 4:
                        Console.WriteLine("Nhập ID sinh viên cần cập nhật:");
                        int idCapNhat;
                        if (!int.TryParse(Console.ReadLine(), out idCapNhat))
                        {
                            Console.WriteLine("ID không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập tên mới:");
                        string tenMoi = Console.ReadLine();
                        if (!KiemTraChuoiKhongChuaSo(tenMoi))
                        {
                            Console.WriteLine("Tên không hợp lệ. Vui lòng không nhập số.");
                            continue;
                        }

                        Console.WriteLine("Nhập giới tính mới:");
                        string gioiTinhMoi = Console.ReadLine();

                        Console.WriteLine("Nhập tuổi mới:");
                        int tuoiMoi;
                        if (!int.TryParse(Console.ReadLine(), out tuoiMoi) || tuoiMoi <= 0)
                        {
                            Console.WriteLine("Tuổi không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập điểm Toán mới:");
                        double diemToanMoi;
                        if (!double.TryParse(Console.ReadLine(), out diemToanMoi) || diemToanMoi < 0 || diemToanMoi > 10)
                        {
                            Console.WriteLine("Điểm Toán không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập điểm Lý mới:");
                        double diemLyMoi;
                        if (!double.TryParse(Console.ReadLine(), out diemLyMoi) || diemLyMoi < 0 || diemLyMoi > 10)
                        {
                            Console.WriteLine("Điểm Lý không hợp lệ.");
                            continue;
                        }

                        Console.WriteLine("Nhập điểm Hóa mới:");
                        double diemHoaMoi;
                        if (!double.TryParse(Console.ReadLine(), out diemHoaMoi) || diemHoaMoi < 0 || diemHoaMoi > 10)
                        {
                            Console.WriteLine("Điểm Hóa không hợp lệ.");
                            continue;
                        }

                        SinhVien svMoi = new SinhVien(tenMoi, gioiTinhMoi, tuoiMoi, diemToanMoi, diemLyMoi, diemHoaMoi);
                        quanLySinhVien.CapNhatSinhVienTheoId(idCapNhat, svMoi);
                        break;

                    case 5:
                        Console.WriteLine("Nhập các ID sinh viên cần xóa (cách nhau bởi dấu phẩy):");
                        string inputIds = Console.ReadLine();
                        List<int> idsXoa = inputIds.Split(',').Select(idStr =>
                        {
                            int id;
                            return int.TryParse(idStr.Trim(), out id) ? id : -1;
                        }).Where(id => id != -1).ToList();
                        quanLySinhVien.XoaSinhVien(idsXoa);
                        break;

                    case 6:
                        quanLySinhVien.HienThiDanhSachSinhVien();
                        break;
                }
            }
        }

        static bool KiemTraChuoiKhongChuaSo(string input)
        {
            // Biểu thức chính quy để kiểm tra chuỗi không chứa số
            string pattern = @"^\D*$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }
    }
}