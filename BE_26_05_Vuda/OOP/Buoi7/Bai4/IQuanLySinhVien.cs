using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai4
{
    // là interface chứa các phương thức quản lý sinh viên.
    public interface IQuanLySinhVien
    {
        void ThemSinhVien(SinhVien sinhVien);
        void ThemSinhVienTuExcel(string filePath);
        void SapXepSinhVien(string tieuChi);
        void CapNhatSinhVienTheoId(int id, SinhVien sinhVien);
        void XoaSinhVien(List<int> ids);
        void HienThiDanhSachSinhVien();
    }
}
