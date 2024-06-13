using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;
using System.Text.RegularExpressions;
using BE_26_05_Vuda;
using System.Runtime.Intrinsics.X86;
using BE_26_05_Vuda.ConsoleApp;
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
            Console.WriteLine("26. Bai tap buoi 6");
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
                case 5:
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
                    Bai22();
                    break;
                case 24:
                    Bai24();
                    break;
                case 25:
                    Bai25();
                    break;
                case 26:
                    Buoi6();
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
        var bai1 = new BE_26_05_Vuda.ConsoleApp.Bai1();
        bai1.TimTongHieuTich();
    }
    #endregion

    #region Bài 2: Giải phương trình bậc 1 và bậc 2
    static void Bai2()
    {
        var bai2 = new BE_26_05_Vuda.ConsoleApp.Bai2();
        bai2.GiaiPhuongTrinh();

    }
    #endregion

    #region Bài 3: Chuyển đổi độ C thành độ K và độ F
    static void Bai3()
    {
        var bai3 = new BE_26_05_Vuda.ConsoleApp.Bai3();
        bai3.ChuyenDoiNhietDo();

    }
    #endregion

    #region Bài 4: Tính giai thừa của một số
    static void Bai4()
    {
        var bai4 = new BE_26_05_Vuda.ConsoleApp.Bai4();
        bai4.TinhGiaiThua();

    }
    #endregion

    #region Bài 5: Liệt kê tất cả các số nguyên tố nhỏ hơn n
    static void Bai5()
    {
        var bai5 = new BE_26_05_Vuda.ConsoleApp.Bai5();
        bai5.SoNguyenToNhoHonN();
    }
    #endregion

    #region Bài 6: Kiểm tra số chẵn hay lẻ
    static void Bai6()
    {
        var bai6 = new BE_26_05_Vuda.ConsoleApp.Bai6();
        bai6.KiemTraChanLe();
    }
    #endregion

    #region Bài 7: Kiểm tra số nguyên tố
    static void Bai7()
    {
        var bai7 = new BE_26_05_Vuda.ConsoleApp.Bai7();
        bai7.KiemTraSoNguyenTo();
    }

    #endregion

    #region Bài 8: Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn
    static void Bai8()
    {
        var bai8 = new BE_26_05_Vuda.ConsoleApp.Bai8();
        bai8.ChiaMangChanLe();
    }
    #endregion

    #region Bài 9: Sắp xếp mảng số nguyên tăng dần và giảm dần
    static void Bai9()
    {
        var bai9 = new BE_26_05_Vuda.ConsoleApp.Bai9();
        bai9.SapXepMang();
    }
    #endregion

    #region Bài 10: Hiển thị số bằng chữ tương ứng
    static void Bai10()
    {
        var bai10 = new BE_26_05_Vuda.ConsoleApp.Bai10();
        bai10.HienThiSoBangChu();
    }


    #endregion

    #region Bài 11: Tính tổng dãy số
    static void Bai11()
    {
        var bai11 = new BE_26_05_Vuda.ConsoleApp.Bai11();
        bai11.TinhTongDaySo();
    }
    #endregion

    #region Bài 12: Tính tổng các số lẻ trong mảng số nguyên
    static void Bai12()
    {
        var bai12 = new BE_26_05_Vuda.ConsoleApp.Bai12();
        bai12.TinhTongSoLeTrongMang();
    }
    #endregion
    #region Bài 19: Tính tổng các phần tử trong mảng
    static void Bai19()
    {
        var bai19 = new BE_26_05_Vuda.ConsoleApp.Bai19();
        bai19.TongPhanTuTrongMang();
    }
    #endregion

    #region Bài 20: Đảo ngược mảng
    static void Bai20()
    {
        var bai20 = new BE_26_05_Vuda.ConsoleApp.Bai20();
        bai20.DaoNguocMang();
    }
    #endregion

    #region Bài 21: Tìm giá trị lớn thứ hai và nhỏ thứ hai trong mảng
    static void Bai21()
    {
        var bai21 = new BE_26_05_Vuda.ConsoleApp.Bai21();
        bai21.TimGiaTriLonThuHaiVaNhoThuHai();
    }
    #endregion

    #region Bài 22: Tìm mảng con có tổng lớn nhất trong mảng 
    static void Bai22()
    {
        var bai22 = new BE_26_05_Vuda.ConsoleApp.Bai22();
        bai22.TimMangConTongLonNhat();
    }
    #endregion

    #region Buổi 4
    static void Bai24()
    {
        var bai24 = new BE_26_05_Vuda.ConsoleApp.Buoi4();
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

    #region Buổi 5
    static void Bai25()
    {
        var bai25 = new BE_26_05_Vuda.ConsoleApp.Buoi5();
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

    #region Buổi 6
    static void Buoi6()
    {
        Console.WriteLine("Chọn 1 bài \n");
        Console.WriteLine("0. Thoát lựa chọn \n");
        Console.WriteLine("1. Generic MyStack ");
        Console.WriteLine("2. Quản lý sinh viên theo ID ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "0":
                return;
            case "1":
                var bai1 = new Buoi6();
                bai1.Bai1();
                break;
            case "2":
                var bai2 = new Buoi6();
                bai2.Bai2();
                break;
            default:
                break;
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
