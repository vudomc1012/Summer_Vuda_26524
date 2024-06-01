using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
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
            Console.WriteLine("5. Liệt kê tất cả các số nguyên tố nhỏ hơn n");
            Console.WriteLine("6. Kiểm tra số chẵn hay lẻ");
            Console.WriteLine("7. Kiểm tra số nguyên tố");
            Console.WriteLine("8. In ra mảng sổ lẻ và mảng số chẵn");
            Console.WriteLine("9. Sap Xep Mang");
            Console.WriteLine("10. Hien Thi So Bang Chu");
            Console.WriteLine("11. Tính tổng dãy số trong C#");
            Console.WriteLine("12. Hiển thị và tính tổng các số lẻ trong C#");
            Console.WriteLine("19. Tính tổng các phần tử trong mảng");
            Console.Write("\nNhập lựa chọn của bạn: ");

            int luaChon = (int)NhapSo("");

            switch (luaChon)
            {
                case 0:
                    return;
                case 1:
                    TimTongHieuTich();
                    break;
                case 2:
                    GiaiPhuongTrinh();
                    break;
                case 3:
                    ChuyenDoiNhietDo();
                    break;
                case 4:
                    TinhGiaiThua();
                    break;
                case 5:
                    LietKeSoNguyenTo();
                    break;
                case 6:
                    KiemTraChanLe();
                    break;
                case 7:
                    KiemTraSoNguyenTo();
                    break;
                case 8:
                    ChiaMangChanLe();
                    break;
                case 9:
                    SapXepMang();
                    break;
                case 10:
                    HienThiSoBangChu();
                    break;
                case 11:
                    TinhTongDaySo();
                    break;
                case 12:
                    TinhTongSoLeTrongMang();
                    break;
                case 19:
                    TongPhanTuTrongMang();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }
    #endregion
    #region Bài 1: Tìm tổng, tích, hiệu của hai số

    static void TimTongHieuTich()
    {
        double soThuNhat = NhapSo("Nhập vào số thứ nhất: ");
        double soThuHai = NhapSo("Nhập vào số thứ hai: ");

        double tong = soThuNhat + soThuHai;
        double hieu = soThuNhat - soThuHai;
        double tich = soThuNhat * soThuHai;

        Console.WriteLine($"Tổng của {soThuNhat} và {soThuHai} là: {tong}");
        Console.WriteLine($"Hiệu của {soThuNhat} và {soThuHai} là: {hieu}");
        Console.WriteLine($"Tích của {soThuNhat} và {soThuHai} là: {tich}");
    }
    #endregion

    #region Bài 2: Giải phương trình bậc 1 và bậc 2
    static void GiaiPhuongTrinh()
    {
        // Giải phương trình bậc 1: ax + b = 0
        Console.WriteLine("Giải phương trình bậc 1: ax + b = 0");
        double a1 = NhapSo("Nhập a: ");
        double b1 = NhapSo("Nhập b: ");
        GiaiPhuongTrinhBac1(a1, b1);

        // Giải phương trình bậc 2: ax^2 + bx + c = 0
        Console.WriteLine("Giải phương trình bậc 2: ax^2 + bx + c = 0");
        double a2 = NhapSo("Nhập a: ");
        double b2 = NhapSo("Nhập b: ");
        double c2 = NhapSo("Nhập c: ");
        GiaiPhuongTrinhBac2(a2, b2, c2);
    }

    static void GiaiPhuongTrinhBac1(double a, double b)
    {
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Phương trình vô số nghiệm.");
            else
                Console.WriteLine("Phương trình vô nghiệm.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Nghiệm của phương trình là: x = {x}");
        }
    }

    static void GiaiPhuongTrinhBac2(double a, double b, double c)
    {
        if (a == 0)
        {
            GiaiPhuongTrinhBac1(b, c);
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
            }
            else
            {
                double canDelta = Math.Sqrt(delta);
                double x1 = (-b + canDelta) / (2 * a);
                double x2 = (-b - canDelta) / (2 * a);
                Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
        }
    }
    #endregion

    #region Bài 3: Chuyển đổi độ C thành độ K và độ F
    static void ChuyenDoiNhietDo()
    {
        double doC = NhapSo("Nhập vào nhiệt độ (°C): ");

        double doK = doC + 273.15;
        double doF = doC * 1.8 + 32;

        Console.WriteLine($"Nhiệt độ Kelvin (K): {doK}");
        Console.WriteLine($"Nhiệt độ Fahrenheit (°F): {doF}");
    }
    #endregion

    #region Bài 4: Tính giai thừa của một số
    static void TinhGiaiThua()
    {
        int so = (int)NhapSo("Nhập vào một số nguyên: ");
        long giaiThua = GiaiThua(so);
        Console.WriteLine($"Giai thừa của {so} là: {giaiThua}");
    }

    static long GiaiThua(int n)
    {
        if (n <= 1) return 1;
        return n * GiaiThua(n - 1);
    }
    #endregion

    #region Bài 5: Liệt kê tất cả các số nguyên tố nhỏ hơn n
    static void LietKeSoNguyenTo()
    {
        int n = (int)NhapSo("Nhập vào một số nguyên dương: ");
        for (int i = 2; i < n; i++)
        {
            if (LaSoNguyenTo(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    #endregion

    #region Bài 6: Kiểm tra số chẵn hay lẻ
    static void KiemTraChanLe()
    {
        int so = (int)NhapSo("Nhập vào một số nguyên: ");
        if (so % 2 == 0)
        {
            Console.WriteLine($"{so} là số chẵn.");
        }
        else
        {
            Console.WriteLine($"{so} là số lẻ.");
        }
    }
    #endregion

    #region Bài 7: Kiểm tra số nguyên tố
    static void KiemTraSoNguyenTo()
    {
        int so = (int)NhapSo("Nhập vào một số nguyên: ");
        if (LaSoNguyenTo(so))
        {
            Console.WriteLine($"{so} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{so} không phải là số nguyên tố.");
        }
    }
    static bool LaSoNguyenTo(int so)
    {
        if (so < 2) return false;
        for (int i = 2; i <= Math.Sqrt(so); i++)
        {
            if (so % i == 0) return false;
        }
        return true;
    }
    #endregion

    #region Bài 8: Cho một mảng số nguyên hãy in ra mảng sổ lẻ và mảng số chẵn
    static void ChiaMangChanLe()
    {
        int n = (int)NhapSo("Nhập số lượng phần tử trong mnảg: ");
        int[] mangSo = new int[n];

        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo($"Nhập phần tử thứ {i + 1}: ");
        }

        List<int> soChan = new List<int>();
        List<int> soLe = new List<int>();

        foreach (int so in mangSo)
        {
            if (so % 2 == 0)
            {
                soChan.Add(so);
            }
            else
            {
                soLe.Add(so);
            }
        }

        Console.WriteLine("Mảng số chẵn: " + string.Join(", \n", soChan));
        Console.WriteLine("Mảng số lẻ: " + string.Join(", \n", soLe));
    }
    #endregion

    #region Bài 9: Sắp xếp mảng số nguyên tăng dần và giảm dần
    static void SapXepMang()
    {
        int n = (int)NhapSo("Nhập vào số lượng phần tử của mảng: ");
        int[] mangSo = new int[n];

        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo($"Nhập phần tử thứ {i + 1}: ");
        }

        Array.Sort(mangSo);
        Console.WriteLine("Mảng số nguyên sau khi sắp xếp tăng dần: " + string.Join(", ", mangSo));

        Array.Reverse(mangSo);
        Console.WriteLine("Mảng số nguyên sau khi sắp xếp giảm dần: " + string.Join(", ", mangSo));
    }
    #endregion

    #region Bài 10: Hiển thị số bằng chữ tương ứng
    static void HienThiSoBangChu()
    {
        int so = (int)NhapSo("Nhập vào một số nguyên: ");
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
        int n = (int)NhapSo("Nhập vào số lượng phần tử của dãy: ");
        int[] daySo = new int[n];

        for (int i = 0; i < n; i++)
        {
            daySo[i] = (int)NhapSo($"Nhập phần tử thứ {i + 1}: ");
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
        int n = (int)NhapSo("Nhập vào số lượng phần tử của mảng: ");
        int[] mangSo = new int[n];

        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo($"Nhập phần tử thứ {i + 1}: ");
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
    {         //(int):convert double ra int
        int n = (int)NhapSo("Nhập số lượng phần tử trong mảng: "); //hiển thị thông báo, \gọi hàm NhapSo dùng regex, 
            int[] mangSo = new int[n];
        for (int i = 0; i < n; i++)
        {
            mangSo[i] = (int)NhapSo($"Nhập số phần tử thứ {i + 1}: ");
        }

        int tong = 0;       
        foreach (int so in mangSo)//mỗi lần lặp, gán giá trị của phần tử hiện tại trong mangSo cho biến so.
        {
            tong += so; //mỗi lần lặp giá trị của phần tử so được cộng vào biến tong
        }

        Console.WriteLine($"Tổng các phần tử trong mảng là: {tong}\n");
    }
    #endregion

    #region Hàm kiểm tra đầu vào
    static double NhapSo(string inputCheck)
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
    }
    #endregion
}