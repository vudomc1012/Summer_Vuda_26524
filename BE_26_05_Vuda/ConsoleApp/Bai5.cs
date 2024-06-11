using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai5
    {
        public void SoNguyenToNhoHonN()
        {
            var LaSoNguyenTo = new SoNguyenTo();
            var NhapSo = new Common.ValidateData();
            int n = (int)NhapSo.NhapSo("Nhập vào một số nguyên dương: ");
            for (int i = 2; i < n; i++)
            {
                if (LaSoNguyenTo.LaSoNguyenTo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
