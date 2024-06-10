using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda
{
    public class Bai10
    {
        static void HienThiSoBangChu()
        {
            var NhapSo = new Common.ValidateData();
            int so = (int)NhapSo.NhapSo("Nhập vào một số nguyên: ");
            string soBangChu = SoThanhChu(so);
            Console.WriteLine($"{so} bằng chữ là: {soBangChu}");
        }
    }
}
