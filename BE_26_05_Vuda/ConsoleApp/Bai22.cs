using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai22
    {
        public void TimMangConTongLonNhat()
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
    }
}
