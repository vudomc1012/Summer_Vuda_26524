using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.DataAccess.DTO
{
    public class CongDoan
    {
        public string MaCongDoan { get; set; }
        public string TenCongDoan { get; set; }
        public int SoLuongSanPham { get; set; }

        public CongDoan(string maCongDoan, string tenCongDoan, int soLuongSanPham)
        {
            MaCongDoan = maCongDoan;
            TenCongDoan = tenCongDoan;
            SoLuongSanPham = soLuongSanPham;
        }
    }
}
