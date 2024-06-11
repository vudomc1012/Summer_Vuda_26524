using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai20
    {
        public void DaoNguocMang()
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
    }
}
