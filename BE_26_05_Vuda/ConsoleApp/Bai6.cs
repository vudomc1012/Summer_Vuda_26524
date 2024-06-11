using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai6
    {
        public void KiemTraChanLe()
        {
            var NhapSo = new Common.ValidateData();
            int so = (int)NhapSo.NhapSo("Nhập vào một số nguyên: ");
            if (so % 2 == 0)
            {
                Console.WriteLine($"{so} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{so} là số lẻ.");
            }
        }
    }
}
