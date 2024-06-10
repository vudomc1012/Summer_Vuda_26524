using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;
using System.Text.RegularExpressions;
using BE_26_05_Vuda;
using System.Runtime.Intrinsics.X86;
class Program
{

    static void Main()
    {

        //NhapSo.NhapSo("Bình thường em nhé , em gọi sai namespace thôi ");
        Console.OutputEncoding = Encoding.UTF8;

        #region Switch Case
        while (true)
        {
            Console.WriteLine("Chọn một bài tập để thực hiện:");
            Console.WriteLine("0.Thoát chương trình\n");
            Console.WriteLine("1. Tìm tổng, tích, hiệu của hai số");
            Console.WriteLine("2. Giải phương trình bậc 1 và bậc 2");
            Console.WriteLine("3. Chuyển đổi độ C thành độ K và độ F");
            Console.WriteLine("4. Tính giai thừa của một số");
            Console.WriteLine("5. Liệt kê tất cả các số nguyên tố nhỏ hơn n\n");
            Console.WriteLine("6. Kiểm tra số chẵn hay lẻ");
            Console.WriteLine("7. Kiểm tra số nguyên tố");
            Console.WriteLine("8. In ra mảng sổ lẻ và mảng số chẵn");
            Console.WriteLine("9. Sắp xếp mảng");
            Console.WriteLine("10. Hiển thị số bằng chữ\n");
            Console.WriteLine("11. Tính tổng dãy số trong C#");
            Console.WriteLine("12. Hiển thị và tính tổng các số lẻ trong C#");
            Console.WriteLine("19. Tính tổng các phần tử trong mảng");
            Console.WriteLine("20. Đảo ngược các phần tử trong mảng\n");
            Console.WriteLine("21. Tìm giá trị lớn thứ 2 và nhỏ thứ 2");
            Console.WriteLine("22. Tìm mảng con tổng lớn nhất");
            Console.WriteLine("24. Phân tích thống kê");
            Console.WriteLine("25. Quản lý nhân sự\n");
            Console.Write("\nNhập lựa chọn của bạn: ");
            var NhapSo = new Common.ValidateData();
            int luaChon = (int)NhapSo.NhapSo("");

            switch (luaChon)
            {
                case 0:
                    return;
                case 1:
                    Bai1();
                    break;
                case 2:
                    Bai2();
                    break;
                case 3:
                    Bai3();
                    break;
                case 4:
                    Bai4();
                    break;
                    /*  case 5:
                          Bai5();
                          break;
                      case 6:
                          Bai6();
                          break;
                      case 7:
                          Bai7();
                          break;
                      case 8:
                          Bai8();
                          break;
                      case 9:
                          Bai9();
                          break;
                      case 10:
                          Bai10();
                          break;
                      case 11:
                          Bai11();
                          break;
                      case 12:
                          Bai12();
                          break;
                      case 19:
                          Bai19();
                          break;
                      case 20:
                          Bai20();
                          break;
                      case 21:
                          Bai21();
                          break;
                      case 22:
                          Bai22();*/
                    break;
                case 24:
                    Bai24();
                    break;
                case 25:
                    Bai25();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }
    #endregion
    #region Bài 1: Tìm tổng, tích, hiệu của hai số
    static void Bai1()
    {
        var bai1 = new Bai1();
        bai1.TimTongHieuTich();
    }
    #endregion

    #region Bài 2: Giải phương trình bậc 1 và bậc 2
    static void Bai2()
    {
        var bai2 = new Bai2();
        bai2.GiaiPhuongTrinh();

    }
    #endregion

    #region Bài 3: Chuyển đổi độ C thành độ K và độ F
    static void Bai3()
    {
        var bai3 = new Bai3();
        bai3.ChuyenDoiNhietDo();

    }
    #endregion

    #region Bài 4: Tính giai thừa của một số
    static void Bai4()
    {
        var bai4 = new Bai4();
        bai4.TinhGiaiThua();

    }


    #endregion

    #region Bài 5: Liệt kê tất cả các số nguyên tố nhỏ hơn n
    static void Bai5()
    {
        var bai5 = new Bai5();
        bai5.SoNguyenToNhoHonN();
    }
    #endregion

    #region Bài 6: Kiểm tra số chẵn hay lẻ
    static void Bai6()
    {
        var bai6 = new Bai6();
        bai6.KiemTraChanLe();
    }
    #endregion

    #region Bài 7: Kiểm tra số nguyên tố
    static void Bai7()
    {
        var bai7 = new Bai7();
        bai7.KiemTraSoNguyenTo();
    }

    #endregion

    #region Bài 8: Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn
    static void Bai8()
    {
        var bai8 = new Bai8();
        bai8.ChiaMangChanLe();
    }
    #endregion

    #region Bài 9: Sắp xếp mảng số nguyên tăng dần và giảm dần
    static void Bai9()
    {
        var bai9 = new Bai9();
        bai9.SapXepMang();
    }
    #endregion

    #region Bài 10: Hiển thị số bằng chữ tương ứng
    static void HienThiSoBangChu()
    {
        var NhapSo = new Common.ValidateData();
        int so = (int)NhapSo.NhapSo("Nhập vào một số nguyên: ");
        string soBangChu = SoThanhChu(so);
        Console.WriteLine($"{so} bằng chữ là: {soBangChu}");
    }

    static string SoThanhChu(int so)
    {
        if (so == 0) return "không";

        string[] donVi = { "", "một", "high", "bar", "bốn", "num", "xáu", "bảy", "tám", "chíng" };
        string[] hangChuc = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        string[] hangTram = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
        string[] hangNghin = { "", "một nghìn", "hai nghìn", "ba nghìn", "bốn nghìn", "năm nghìn", "sáu nghìn", "bảy nghìn", "tám nghìn", "chín nghìn" };

        string ketQua = "\n";
        if (so >= 1000)
        {
            ketQua += hangNghin[so / 1000] + " ";
            so += 100;
        }
        if (so >= 100)
        {
            ketQua += hangTram[so / 100] + " ";
            so %= 100;
        }

        if (so >= 10)
        {
            ketQua += hangChuc[so / 10] + " ";
            so %= 10;
        }

        if (so > 0)
        {
            ketQua += donVi[so] + " ";
        }

        return ketQua.Trim();
    }
    #endregion

    #region Bài 11: Tính tổng dãy số
    static void TinhTongDaySo()
    {
        var NhapSo = new Common.ValidateData();
        int n = (int)NhapSo.NhapSo(("Nhập vào số lượng phần tử của dãy: "));
        int[] daySo = new int[n];

        for (int i = 0; i < n; i++)
        {
            daySo[i] = (int)NhapSo.NhapSo(($"Nhập phần tử thứ {i + 1}: "));
        }

        int tong = 0;
        foreach (int so in daySo)
        {
            tong += so;
        }

        Console.WriteLine($"Tổng của dãy số là: {tong}\n");
    }
    #endregion

    #region Bài 12: Tính tổng các số lẻ trong mảng số nguyên
    static void TinhTongSoLeTrongMang()
    {
        var NhapSo = new Common.ValidateData();
        int n = (int)NhapSo.NhapSo(("Nhập vào số lượng phần tử của mảng: "));
        int[] mangSo = new int[n];

        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo.NhapSo($"Nhập phần tử thứ {i + 1}: ");
        }

        int tongSoLe = 0;
        List<int> soLe = new List<int>();

        foreach (int so in mangSo)
        {
            if (so % 2 != 0)
            {
                soLe.Add(so);
                tongSoLe += so;
            }
        }

        Console.WriteLine("Các số lẻ trong mảng: " + string.Join(", ", soLe));
        Console.WriteLine($"Tổng các số lẻ trong mảng là: {tongSoLe}\n");
    }
    #endregion

    #region Bài 19: Tính tổng các phần tử trong mảng
    static void TongPhanTuTrongMang()
    {
        var NhapSo = new Common.ValidateData();
        {         //(int):convert double ra int
            int n = (int)NhapSo.NhapSo("Nhập số lượng phần tử trong mảng: "); //hiển thị thông báo, \gọi hàm NhapSo dùng regex, 
            int[] mangSo = new int[n];
            for (int i = 0; i < n; i++)
            {
                mangSo[i] = (int)NhapSo.NhapSo($"Nhập số phần tử thứ {i + 1}: ");
            }

            int tong = 0;
            foreach (int so in mangSo)//mỗi lần lặp, gán giá trị của phần tử hiện tại trong mangSo cho biến so.
            {
                tong += so; //mỗi lần lặp giá trị của phần tử so được cộng vào biến tong
            }
            Console.WriteLine($"Tổng các phần tử trong mảng là: {tong}\n");
        }
        //Console.WriteLine($"Tổng các phần tử trong mảng là: {tong}\n");

    }
    #endregion

    #region Bài 20: Đảo ngược mảng
    static void DaoNguocMang()
    {
        var NhapSo = new Common.ValidateData();
        int n = (int)NhapSo.NhapSo("Nhập số lượng phần tử có trong mảng: ");
        int[] mangSo = new int[n];
        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo.NhapSo($"Nhập số phần tử thứ {i + 1}: ");
        }
        Array.Reverse(mangSo);
        Console.WriteLine("Mảng sau khi đảo ngược: " + string.Join(", \n", mangSo));
    }
    #endregion

    #region Bài 21: Tìm giá trị lớn thứ hai và nhỏ thứ hai trong mảng
    static void TimGiaTriLonThuHaiVaNhoThuHai()
    {
        var NhapSo = new Common.ValidateData();
        int n = (int)NhapSo.NhapSo("Nhập số lượng phần tử trong mảng: ");
        int[] mangSo = new int[n];

        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo.NhapSo($"Nhập phần tử thứ {i + 1}: ");
        }

        if (n < 2)
        {
            Console.WriteLine("Mảng phải có ít nhất 2 phần tử để tìm giá trị lớn thứ hai và nhỏ thứ hai.");
            return;
        }

        Array.Sort(mangSo);
        int lonThuHai = mangSo[n - 2];
        int nhoThuHai = mangSo[1];

        Console.WriteLine($"Giá trị lớn thứ hai trong mảng là: {lonThuHai}");
        Console.WriteLine($"Giá trị nhỏ thứ hai trong mảng là: {nhoThuHai}");
    }
    #endregion

    #region Bài 22: Tìm mảng con có tổng lớn nhất trong mảng 
    static void TimMangConTongLonNhat()
    {
        var NhapSo = new Common.ValidateData();
        int n = (int)NhapSo.NhapSo("Nhập số lượng phần tử trong mảng: ");
        int[] mangSo = new int[n];

        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo.NhapSo($"Nhập phần tử thứ {i + 1}: ");
        }

        int maxSoFar = mangSo[0];
        int maxEndingHere = mangSo[0];

        for (int i = 1; i < n; i++)
        {
            maxEndingHere = Math.Max(mangSo[i], maxEndingHere + mangSo[i]);
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        Console.WriteLine($"Tổng lớn nhất của mảng con là: {maxSoFar}");
    }
    #endregion

    #region Bai 24

    static void Bai24()
    {
        var bai24 = new Bai24();
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
                        bai24.NhapDanhSachSinhVien();
                        break;
                    case "2":
                        bai24.HienThiDanhSachSinhVien();
                        break;
                    case "3":
                        bai24.LietKeSinhVienTienBo();
                        break;
                    case "4":
                        bai24.TimKiemSinhVien();
                        break;
                    case "5":
                        bai24.XuatDanhSachSinhVienRaFileCSV();
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
    #endregion

    #region
    static void Bai25()
    {
        var bai25 = new Bai25();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Nhập danh sách Nhân viên từ bàn phím");
            Console.WriteLine("2. Nhập danh sách nhân viên từ file excel có sẵn");
            Console.WriteLine("3. Hiển thị danh sách nhân viên");
            Console.WriteLine("4. Xuất file excel danh sách nhân viên theo các mốc 5 năm và 10 năm");
            Console.WriteLine("0. Thoát");
            Console.Write("Lựa chọn của bạn: ");
            string choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1":
                        bai25.InputEmployeesFromKeyboard();
                        break;
                    case "2":
                        bai25.InputEmployeesFromExcel();
                        break;
                    case "3":
                        bai25.DisplayEmployees();
                        break;
                    case "4":
                        bai25.ExportEmployeesToExcel();
                        break;
                    case "5":
                        Console.WriteLine("Thoát chương trình.");
                        break;
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
    #endregion

    #region Hàm kiểm tra đầu vào
    /* static double NhapSo(string inputCheck)
     {
         double so;
         while (true)
         {
             Console.Write(inputCheck);
             string nhap = Console.ReadLine();

             string mau = @"^-?\d+(\.\d+)?$";
             Regex regex = new Regex(mau);

             if (regex.IsMatch(nhap) && double.TryParse(nhap, out so))
             {
                 return so;
             }
             else
             {
                 Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập lại.");
             }
         }
     }*/
    #endregion

}