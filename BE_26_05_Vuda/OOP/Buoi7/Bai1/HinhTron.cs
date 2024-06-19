using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_26_05_Vuda.OOP.Buoi7.AbstractClass;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai1
{
    public class HinhTron : HinhHocBase
    {

        public double _banKinhR { get; set; }

        public double _chuVi { get; set; }

        public override int chuvi()
        {
            Console.WriteLine("Chu vi hình tròn là: {0}", 2 * 3.14 * _banKinhR);
            return (int)(2 * 3.14 * _banKinhR);
            //convert to int

        }
        //C^2 / 4π
        public override int dientich()
        {
            Console.WriteLine("Dien tich hinh tron la: {0}", _chuVi * _chuVi / (4 * 3.14));
            return (int)(_chuVi * _chuVi / (4 * 3.14));
            //convert to int
        }
    }
}

