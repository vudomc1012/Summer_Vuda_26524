using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
        //Bài 1: Viết chương trình C# để giải bài tập tìm tổng hai số , tích 2 số , hiệu 2 số
        int soA;
        int soB;
        Console.Write("Nhap so A: \n");
        soA = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap so B: \n");
        soB = Convert.ToInt32(Console.ReadLine());

        // Tổng 2 số
        Console.WriteLine("Tong cua hai so la:   {2}", soA, soB, soA + soB);

        // Tích 2 số
        Console.WriteLine("Tich cua hai so la:   {2}", soA, soB, soA * soB);

        // Hiệu 2 số
        Console.WriteLine("Thuong cua hai so la: {2}", soA, soB, soA - soB);


        //Bài 2: Viết Chương trình giải phương trình bậc 1 , bậc 2 ( 2x2 + 3x +1=0)
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Nhập a: ");
        float a = float.Parse(Console.ReadLine());

        Console.WriteLine("Nhập b: ");
        float b = float.Parse(Console.ReadLine());

        Console.WriteLine("Nhập c: ");
        float c = float.Parse(Console.ReadLine());

        float delta = b / 2 * (b / 2) - a * c;

        Console.WriteLine("Phương trình nhập vào là:\n {0}x*x + {1}x + {2} = 0", a, b, c);

        Console.WriteLine("Delta phẩy = {0}", delta);

        switch (delta < 0)
        {
            case true:
                Console.WriteLine("Chương trình vô nghiệm");
                break;
            case false:
                switch (delta == 0)
                {
                    case true:
                        float x = -b / 2 / a;
                        Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0}", x);
                        break;
                    default:
                        double x1 = 0;
                        double x2 = 0;

                        x1 = (-b / 2 + Math.Sqrt(delta)) / a;
                        x2 = (-b / 2 - Math.Sqrt(delta)) / a;

                        Console.WriteLine("Phương trình có 2 nghiệm phân biệt: ");
                        Console.WriteLine("x1 = {0}", x1);
                        Console.WriteLine("x2 = {0}", x2);
                        break;
                }
                break;
        }
        //Console.ReadKey();

        //Bài 3: Viết chương trình C# để giải bài tập chuyển đổi độ C thành độ K và độ F trong C# 
        //1 K = 1 C + 273
        //1 F = C * 18 / 10 + 32
        double C, K, F;

        Console.WriteLine(" Nhập độ C: ");
        C = double.Parse(Console.ReadLine());
        K = C + 273;
        F = C * 18 / 10 + 32;
        Console.WriteLine(" {0} độ C = {1} độ K ", C, K);
        Console.WriteLine(" {0} độ C = {2} độ F ", C, K, F);


        //Bài 4: Tính giai thừa của 1 số 
        int n,
            giaiThua = 1;
        Console.WriteLine("Nhập số muốn tính giai thừa:  ");
        n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        Console.WriteLine($"{n}! = {giaiThua}");


        //Bài 5: Viết chương trình C# liệt kê tất cả các số nguyên tố nhỏ hơn n.
        int number;
        bool IsPrime = true;
        Console.WriteLine("Nhập vào một số : ");
        number = int.Parse(Console.ReadLine());
        if (number == 0 || number == 1 || number < 2)
        {
            IsPrime = false;
        }
        for (int i = 2; i < number / 2; i++)
        {
            if (number % i == 0)
            {
                IsPrime = false;
                break;
            }
            else
            {
                Console.Write("Tat ca cac so nguyen to nho hon {0} la: ", number);
            }
         
           
        }
           

    }
}