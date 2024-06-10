using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda
{
    public class Bai8
    {
        public void ChiaMangChanLe()
        {
            var NhapSo = new Common.ValidateData();
            int n = (int)NhapSo.NhapSo("Nhập số lượng phần tử trong mnảg: ");
            int[] mangSo = new int[n];

            for (int i = 0; i < n; i++)
            {
                mangSo[i] = (int)NhapSo.NhapSo($"Nhập phần tử thứ {i + 1}: ");
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
    }
}
