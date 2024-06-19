using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Common
{
    public class ValidateData
    {
        public double NhapSo(string inputCheck)
        {
            double so;
            while (true)
            {
                Console.Write(inputCheck);
                string nhap = Console.ReadLine();

                string mau = @"^-?\d+(\.\d+)?$";
                Regex regex = new Regex(mau);

                if (regex.IsMatch(nhap) && double.TryParse(nhap, out so))
                {
                    return so;
                }
                else
                {
                    Console.WriteLine("Đầu vào không hợp lệ. Vui lòng nhập lại.");
                }
            }
        }
        public bool NhapChu(string input)
        {
            // Biểu thức chính quy để kiểm tra chuỗi không chứa số
            string pattern = @"^\D*$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(input);
        }

    }
}
