using BE_26_05_Vuda.OOP.Buoi7.Bai4;
using BE_26_05_Vuda.OOP.Buoi7.DAL;
using BE_26_05_Vuda.OOP.DTO;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.DAL.Implement
{
    //QuanLySinhVien triển khai IQuanLySinhVien và chứa logic quản lý sinh viên.
    public class QuanLySinhVien : IQuanLySinhVien
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sinhVien)
        {
            var returnData = new ReturnData();
            try
            {
                // Bước 1: Kiểm tra đầu vào 
                if (sinhVien == null
                    || string.IsNullOrEmpty(sinhVien.Ten))
                {
                    returnData.ResponseCode = -1;
                    returnData.ResponseMessenger = "Tên không được trống!";
                    
                }

                // Bước 2: Check ký tự đặc biệt , ... xss 

                var checkName = new Common.ValidateData().NhapChu(sinhVien.Ten);
                if (!checkName)
                {
                    returnData.ResponseCode = -2;
                    returnData.ResponseMessenger = "Tên không được chưa ký tự đặc biệt!";
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (sinhVien == null ||
                string.IsNullOrEmpty(sinhVien.Ten) ||
                string.IsNullOrEmpty(sinhVien.GioiTinh) ||
                sinhVien.Tuoi <= 0 ||
                sinhVien.DiemToan < 0 || sinhVien.DiemToan > 10 ||
                sinhVien.DiemLy < 0 || sinhVien.DiemLy > 10 ||
                sinhVien.DiemHoa < 0 || sinhVien.DiemHoa > 10)
            {
                Console.WriteLine("Dữ liệu sinh viên không hợp lệ.");
                return;
            }
            danhSachSinhVien.Add(sinhVien);
        }

        public void ThemSinhVienTuExcel(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                for (int row = 2; row <= rowCount; row++) // Bỏ qua hàng tiêu đề
                {
                    string ten = worksheet.Cells[row, 1].Text;
                    string gioiTinh = worksheet.Cells[row, 2].Text;
                    int tuoi = int.Parse(worksheet.Cells[row, 3].Text);
                    double diemToan = double.Parse(worksheet.Cells[row, 4].Text);
                    double diemLy = double.Parse(worksheet.Cells[row, 5].Text);
                    double diemHoa = double.Parse(worksheet.Cells[row, 6].Text);

                    SinhVien sv = new SinhVien(ten, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
                    ThemSinhVien(sv);
                }
            }
        }

        public void SapXepSinhVien(string tieuChi)
        {
            switch (tieuChi)
            {
                case "ten":
                    danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.Ten).ToList();
                    break;
                case "hocLuc":
                    danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.HocLuc).ToList();
                    break;
                case "diemTrungBinh":
                    danhSachSinhVien = danhSachSinhVien.OrderByDescending(sv => sv.DiemTrungBinh).ToList();
                    break;
                default:
                    Console.WriteLine("Tiêu chí sắp xếp không hợp lệ.");
                    break;
            }
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

        public void XoaSinhVien(List<int> ids)
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
