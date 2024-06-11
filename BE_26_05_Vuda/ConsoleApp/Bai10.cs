using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai10
    {
        public void HienThiSoBangChu()
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
    }
}
