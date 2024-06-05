using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static BE_26_05_Vuda.Bai24;

namespace BE_26_05_Vuda
{
    public class Bai24
    {
        enum HocLuc
        {
            XuatSac,
            Gioi,
            Kha,
            TrungBinh,
            Yeu
        }

        struct SinhVien
        {
            public string ID;
            public string Ten;
            public int Tuoi;
            public double DiemHK1;
            public double DiemHK2;

            public double DiemTongKet => (DiemHK1 + DiemHK2) / 2.0;
            public HocLuc XepLoai
            {
                get
                {
                    if (DiemTongKet >= 9) return HocLuc.XuatSac;
                    else if (DiemTongKet >= 8) return HocLuc.Gioi;
                    else if (DiemTongKet >= 7) return HocLuc.Kha;
                    else if (DiemTongKet >= 5) return HocLuc.TrungBinh;
                    else return HocLuc.Yeu;
                }
            }

            static List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Chọn chức năng:");
                    Console.WriteLine("1. Nhập danh sách sinh viên");
                    Console.WriteLine("2. Hiển thị danh sách sinh viên và sinh viên có điểm tổng kết cao nhất");
                    Console.WriteLine("3. Liệt kê sinh viên có tiến bộ trong học tập");
                    Console.WriteLine("4. Tìm kiếm sinh viên");
                    Console.WriteLine("5. Xuất danh sách sinh viên ra file CSV");
                    Console.WriteLine("6. Thoát");

                    string choice = Console.ReadLine();

                    try
                    {
                        switch (choice)
                        {
                            case "1":
                                NhapDanhSachSinhVien();
                                break;
                            case "2":
                                HienThiDanhSachSinhVien();
                                break;
                            case "3":
                                LietKeSinhVienTienBo();
                                break;
                            case "4":
                                TimKiemSinhVien();
                                break;
                            case "5":
                                XuatDanhSachSinhVienRaFileCSV();
                                break;
                            case "6":
                                return;
                            default:
                                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Có lỗi xảy ra: " + ex.Message);
                    }
                }
            }

            static void NhapDanhSachSinhVien()
            {
                for (int i = 0; i < 5; i++)
                {
                    SinhVien sv = new SinhVien();
                    Console.Write("Nhập ID: ");
                    sv.ID = Console.ReadLine();
                    Console.Write("Nhập tên: ");
                    sv.Ten = Console.ReadLine();
                    Console.Write("Nhập tuổi: ");
                    sv.Tuoi = int.Parse(Console.ReadLine());
                    Console.Write("Nhập điểm tổng kết học kì 1: ");
                    sv.DiemHK1 = int.Parse(Console.ReadLine());
                    Console.Write("Nhập điểm tổng kết học kì 2: ");
                    sv.DiemHK2 = int.Parse(Console.ReadLine());

                    danhSachSinhVien.Add(sv);
                }
            }

            static void HienThiDanhSachSinhVien()
            {
                if (danhSachSinhVien.Count == 0)
                {
                    Console.WriteLine("Danh sách sinh viên trống.");
                    return;
                }

                foreach (var sv in danhSachSinhVien)
                {
                    Console.WriteLine($"ID: {sv.ID}, Tên: {sv.Ten}, Tuổi: {sv.Tuoi}, Điểm HK1: {sv.DiemHK1}, Điểm HK2: {sv.DiemHK2}, Điểm Tổng Kết: {sv.DiemTongKet}, Xếp Loại: {sv.XepLoai}");
                }

                var svCaoNhat = danhSachSinhVien.OrderByDescending(s => s.DiemTongKet).First();
                Console.WriteLine($"Sinh viên có điểm tổng kết cao nhất: {svCaoNhat.Ten} với điểm tổng kết {svCaoNhat.DiemTongKet}");
            }

            static void LietKeSinhVienTienBo()
            {
                var svTienBo = danhSachSinhVien.Where(s => s.DiemHK2 > s.DiemHK1).ToList();

                if (svTienBo.Count == 0)
                {
                    Console.WriteLine("Không có sinh viên nào có tiến bộ.");
                    return;
                }

                Console.WriteLine("Danh sách sinh viên có tiến bộ:");
                foreach (var sv in svTienBo)
                {
                    Console.WriteLine($"ID: {sv.ID}, Tên: {sv.Ten}, Tuổi: {sv.Tuoi}, Điểm HK1: {sv.DiemHK1}, Điểm HK2: {sv.DiemHK2}, Điểm Tổng Kết: {sv.DiemTongKet}, Xếp Loại: {sv.XepLoai}");
                }
            }

            static void TimKiemSinhVien()
            {
                Console.WriteLine("Tìm kiếm theo:");
                Console.WriteLine("1. ID");
                Console.WriteLine("2. Tên");
                Console.WriteLine("3. Loại học lực");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Nhập ID cần tìm: ");
                        string id = Console.ReadLine();
                        var svTheoID = danhSachSinhVien.Where(s => s.ID.Equals(id, StringComparison.OrdinalIgnoreCase)).ToList();
                        HienThiKetQuaTimKiem(svTheoID);
                        break;
                    case "2":
                        Console.Write("Nhập tên cần tìm: ");
                        string ten = Console.ReadLine();
                        var svTheoTen = danhSachSinhVien.Where(s => s.Ten.Equals(ten, StringComparison.OrdinalIgnoreCase)).ToList();
                        HienThiKetQuaTimKiem(svTheoTen);
                        break;
                    case "3":
                        Console.WriteLine("Chọn loại học lực cần tìm:");
                        foreach (var xepLoai in Enum.GetValues(typeof(HocLuc)))
                        {
                            Console.WriteLine($"{(int)xepLoai}. {xepLoai}");
                        }
                        int loai = int.Parse(Console.ReadLine());
                        var svTheoHocLuc = danhSachSinhVien.Where(s => s.XepLoai == (HocLuc)loai).ToList();
                        HienThiKetQuaTimKiem(svTheoHocLuc);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }

            static void HienThiKetQuaTimKiem(List<SinhVien> svTimKiem)
            {
                if (svTimKiem.Count == 0)
                {
                    Console.WriteLine("Không tìm thấy sinh viên nào.");
                    return;
                }

                foreach (var sv in svTimKiem)
                {
                    Console.WriteLine($"ID: {sv.ID}, Tên: {sv.Ten}, Tuổi: {sv.Tuoi}, Điểm HK1: {sv.DiemHK1}, Điểm HK2: {sv.DiemHK2}, Điểm Tổng Kết: {sv.DiemTongKet}, Xếp Loại: {sv.XepLoai}");
                }
            }

            static void XuatDanhSachSinhVienRaFileCSV()
            {

            }

        }
    }
}
