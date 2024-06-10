using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda
{
    public class Bai7
    {
        public void KiemTraSoNguyenTo()
        {
            var LaSoNguyenTo = new SoNguyenTo();
            var NhapSo = new Common.ValidateData();
            int so = (int)NhapSo.NhapSo("Nhập vào một số nguyên: ");
            if (LaSoNguyenTo.LaSoNguyenTo(so))
            {
                Console.WriteLine($"{so} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{so} không phải là số nguyên tố.");
            }
        }
    }
}
