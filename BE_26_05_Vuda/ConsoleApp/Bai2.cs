using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.ConsoleApp
{
    public class Bai2
    {
        public void GiaiPhuongTrinh()
        {
            var NhapSo = new Common.ValidateData();
            // Giải phương trình bậc 1: ax + b = 0
            Console.WriteLine("Giải phương trình bậc 1: ax + b = 0");
            double a1 = NhapSo.NhapSo("Nhập a: ");
            double b1 = NhapSo.NhapSo("Nhập b: ");
            GiaiPhuongTrinhBac1(a1, b1);

            // Giải phương trình bậc 2: ax^2 + bx + c = 0
            Console.WriteLine("Giải phương trình bậc 2: ax^2 + bx + c = 0");
            double a2 = NhapSo.NhapSo("Nhập a: ");
            double b2 = NhapSo.NhapSo("Nhập b: ");
            double c2 = NhapSo.NhapSo("Nhập c: ");
            GiaiPhuongTrinhBac2(a2, b2, c2);
        }
        static void GiaiPhuongTrinhBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Phương trình vô số nghiệm.");
                else
                    Console.WriteLine("Phương trình vô nghiệm.");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine($"Nghiệm của phương trình là: x = {x}");
            }
        }

        static void GiaiPhuongTrinhBac2(double a, double b, double c)
        {
            if (a == 0)
            {
                GiaiPhuongTrinhBac1(b, c);
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm.");
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
                }
                else
                {
                    double canDelta = Math.Sqrt(delta);
                    double x1 = (-b + canDelta) / (2 * a);
                    double x2 = (-b - canDelta) / (2 * a);
                    Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
                }
            }
        }
    }
}
