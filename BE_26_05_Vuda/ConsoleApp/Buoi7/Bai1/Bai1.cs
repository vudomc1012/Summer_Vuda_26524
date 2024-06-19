using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp.Buoi7.Bai1
{
    public class Bai1
    {
        public void Buoi7b1()
        {
            var nhapSo = new ValidateData();
            var hinhCNhat = new HinhCNhat();

            Console.WriteLine("1. Tính chu vi hình chữ nhật");
            Console.WriteLine("2. Tính diện tích hình chữ nhật");
            Console.WriteLine("3. Thoát");
            int choice = (int)nhapSo.NhapSo(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("nhập chiều dài: ");
                    hinhCNhat._chieuDai = (int)nhapSo.NhapSo(Console.ReadLine());
                    Console.WriteLine("nhập chiều rộng: ");
                    //convert to int
                    hinhCNhat._chieuRong = (int)nhapSo.NhapSo(Console.ReadLine());
                    hinhCNhat.chuvi();
                    break;

                case 2:
                    Console.WriteLine("nhập chiều dài: ");
                    hinhCNhat._chieuDai = (int)nhapSo.NhapSo(Console.ReadLine());
                    Console.WriteLine("nhập chiều rộng: ");
                    //convert to int
                    hinhCNhat._chieuRong = (int)nhapSo.NhapSo(Console.ReadLine());
                    hinhCNhat.dientich();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
        public void Buoi7b2()
        {
            var nhapSo = new ValidateData();
            var hinhTron = new HinhTron();
            Console.WriteLine("1. Tính chu vi hình trònt");
            Console.WriteLine("2. Tính diện tích hình chữ nhật");
            Console.WriteLine("3. Thoát");
            int choice = (int)nhapSo.NhapSo(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Nhập kính hình tròn");
                    //convert to int
                    hinhTron._banKinhR = (int)nhapSo.NhapSo(Console.ReadLine());
                    hinhTron.chuvi();
                    break;
                case 2:
                    Console.WriteLine("Nhập chu vi hình tròn");
                    hinhTron._chuVi = (int)nhapSo.NhapSo(Console.ReadLine());
                    hinhTron.dientich();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

        }
    }
}
