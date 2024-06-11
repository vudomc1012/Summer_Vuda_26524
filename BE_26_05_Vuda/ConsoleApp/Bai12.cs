using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai12
    {
        public void TinhTongSoLeTrongMang()
        {
            var NhapSo = new Common.ValidateData();
            int n = (int)NhapSo.NhapSo("Nhập vào số lượng phần tử của mảng: ");
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
    }
}
