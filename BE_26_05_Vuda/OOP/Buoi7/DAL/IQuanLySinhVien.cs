using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_26_05_Vuda.OOP.Buoi7.Bai4;
using BE_26_05_Vuda.OOP.DTO;
using static BE_26_05_Vuda.ConsoleApp.Buoi6;

namespace BE_26_05_Vuda.OOP.Buoi7.DAL
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

    public interface IStudentDAL
    {
        ReturnData Student_Insert(Student requestData);
    }
}
