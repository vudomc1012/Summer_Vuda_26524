using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai21
    {
        public void TimGiaTriLonThuHaiVaNhoThuHai()
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
    }
}
