using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai19
    {
        public void TongPhanTuTrongMang()
        {
            var NhapSo = new Common.ValidateData();
            {         //(int):convert double ra int
                int n = (int)NhapSo.NhapSo("Nhập số lượng phần tử trong mảng: "); //hiển thị thông báo, \gọi hàm NhapSo dùng regex, 
                int[] mangSo = new int[n];
                for (int i = 0; i < n; i++)
                {
                    mangSo[i] = (int)NhapSo.NhapSo($"Nhập số phần tử thứ {i + 1}: ");
                }

                int tong = 0;
                foreach (int so in mangSo)//mỗi lần lặp, gán giá trị của phần tử hiện tại trong mangSo cho biến so.
                {
                    tong += so; //mỗi lần lặp giá trị của phần tử so được cộng vào biến tong
                }
                Console.WriteLine($"Tổng các phần tử trong mảng là: {tong}\n");
            }
            //Console.WriteLine($"Tổng các phần tử trong mảng là: {tong}\n");

        }
    }
}
