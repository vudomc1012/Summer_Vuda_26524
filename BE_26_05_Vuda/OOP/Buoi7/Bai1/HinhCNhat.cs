using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BE_26_05_Vuda.OOP.Buoi7.AbstractClass;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai1
{
    public class HinhCNhat : HinhHocBase
    {
        public int _chieuDai { get; set; }
        public int _chieuRong { get; set; }

        public override int chuvi()
        {
            Console.WriteLine("Chu vi hình chữ nhật là {0}", (_chieuDai + _chieuRong) * 2);
            return (_chieuDai + _chieuRong) * 2;
        }

        public override int dientich()
        {
            Console.WriteLine("Diện tích hình chữ nhật là {0}", _chieuRong * _chieuDai);
            return _chieuDai * _chieuRong;


        }
    }
}
