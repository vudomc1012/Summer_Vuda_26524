using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda
{
    public class Bai4
    {
        public void TinhGiaiThua()
        {
            var NhapSo = new Common.ValidateData();
            int so = (int)NhapSo.NhapSo("Nhập vào một số nguyên: ");
            long giaiThua = GiaiThua(so);
            Console.WriteLine($"Giai thừa của {so} là: {giaiThua}");
        }

        static long GiaiThua(int n)
        {
            if (n <= 1) return 1;
            return n * GiaiThua(n - 1);
        }
    }
}
