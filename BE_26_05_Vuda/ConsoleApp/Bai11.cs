using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai11
    {
        public void TinhTongDaySo()
        {
            var NhapSo = new Common.ValidateData();
            int n = (int)NhapSo.NhapSo("Nhập vào số lượng phần tử của dãy: ");
            int[] daySo = new int[n];

            for (int i = 0; i < n; i++)
            {
                daySo[i] = (int)NhapSo.NhapSo($"Nhập phần tử thứ {i + 1}: ");
            }

            int tong = 0;
            foreach (int so in daySo)
            {
                tong += so;
            }

            Console.WriteLine($"Tổng của dãy số là: {tong}\n");
        }
    }
}
