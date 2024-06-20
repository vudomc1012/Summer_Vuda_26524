using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai4
{
    public class QuanLySinhVien : IQuanLySinhVien
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sinhVien)
        {
            danhSachSinhVien.Add(sinhVien);
        }

        public void ThemSinhVienTuExcel(string filePath)
        {
            // TODO: Thêm code đọc từ file Excel
        }

        public void SapXepSinhVienTheoTen()
        {
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.Ten).ToList();
        }

        public void SapXepSinhVienTheoHocLuc()
        {
            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.HocLuc).ToList();
        }

        public void SapXepSinhVienTheoDiemTrungBinh()
        {
            danhSachSinhVien = danhSachSinhVien.OrderByDescending(sv => sv.DiemTrungBinh).ToList();
        }

        public void CapNhatSinhVienTheoId(int id, SinhVien sinhVien)
        {
            var sv = danhSachSinhVien.FirstOrDefault(s => s.Id == id);
            if (sv != null)
            {
                sv.Ten = sinhVien.Ten;
                sv.GioiTinh = sinhVien.GioiTinh;
                sv.Tuoi = sinhVien.Tuoi;
                sv.CapNhatDiem(sinhVien.DiemToan, sinhVien.DiemLy, sinhVien.DiemHoa);
            }
        }
        public void XoaSinhVienTheoId(int id)
        {
            danhSachSinhVien.RemoveAll(sv => sv.Id == id);
        }

        public void XoaNhieuSinhVienTheoId(List<int> ids)
        {
            danhSachSinhVien.RemoveAll(sv => ids.Contains(sv.Id));
        }

        public void HienThiDanhSachSinhVien()
        {
            foreach (var sinhVien in danhSachSinhVien)
            {
                Console.WriteLine(sinhVien);
            }
        }
    }
}
