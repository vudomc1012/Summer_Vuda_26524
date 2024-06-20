using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai4
{
    public interface IQuanLySinhVien
    {
        void ThemSinhVien(SinhVien sinhVien);
        void ThemSinhVienTuExcel(string filePath);
        void SapXepSinhVienTheoTen();
        void SapXepSinhVienTheoHocLuc();
        void SapXepSinhVienTheoDiemTrungBinh();
        void CapNhatSinhVienTheoId(int id, SinhVien sinhVien);
        void XoaSinhVienTheoId(int id);
        void XoaNhieuSinhVienTheoId(List<int> ids);
        void HienThiDanhSachSinhVien();
    }
}
