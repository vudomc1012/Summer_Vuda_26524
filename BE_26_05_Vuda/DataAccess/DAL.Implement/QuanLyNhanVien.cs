using BE_26_05_Vuda.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.DataAccess.DAL.Implement
{
    public class QuanLyNhanVien : IQuanLyNhanVien
    {
        private List<NhanVien> nhanViens;

        public QuanLyNhanVien()
        {
            nhanViens = new List<NhanVien>();
        }

        public void ThemNhanVien()
        {
            try
            {
                Console.Write("Nhập ID: ");
                if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
                {
                    Console.WriteLine("ID không hợp lệ.");
                    return;
                }

                Console.Write("Nhập tên: ");
                string ten = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(ten))
                {
                    Console.WriteLine("Tên không được để trống.");
                    return;
                }

                Console.Write("Nhập giới tính: ");
                string gioiTinh = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(gioiTinh))
                {
                    Console.WriteLine("Giới tính không được để trống.");
                    return;
                }

                Console.Write("Nhập tuổi: ");
                if (!int.TryParse(Console.ReadLine(), out int tuoi) || tuoi <= 0)
                {
                    Console.WriteLine("Tuổi phải lớn hơn 0.");
                    return;
                }

                Console.Write("Nhập lương cơ bản: ");
                if (!double.TryParse(Console.ReadLine(), out double luongCoBan) || luongCoBan <= 0)
                {
                    Console.WriteLine("Lương cơ bản phải lớn hơn 0.");
                    return;
                }

                Console.Write("Nhập hệ số lương: ");
                if (!double.TryParse(Console.ReadLine(), out double heSoLuong) || heSoLuong <= 0)
                {
                    Console.WriteLine("Hệ số lương phải lớn hơn 0.");
                    return;
                }

                Console.Write("Nhập phụ cấp: ");
                if (!double.TryParse(Console.ReadLine(), out double phuCap) || phuCap < 0)
                {
                    Console.WriteLine("Phụ cấp không được nhỏ hơn 0.");
                    return;
                }

                NhanVien nhanVien = new NhanVien
                {
                    Id = id,
                    Ten = ten,
                    GioiTinh = gioiTinh,
                    Tuoi = tuoi,
                    LuongCoBan = luongCoBan,
                    HeSoLuong = heSoLuong,
                    PhuCap = phuCap
                };

                if (nhanVien != null && !nhanViens.Exists(nv => nv.Id == nhanVien.Id))
                {
                    nhanViens.Add(nhanVien);
                    Console.WriteLine("Thêm nhân viên thành công.");
                }
                else
                {
                    Console.WriteLine("Nhân viên đã tồn tại hoặc thông tin không hợp lệ.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Dữ liệu nhập vào không hợp lệ.");
            }
        }

        public NhanVien TimKiemNhanVien(int id)
        {
            if (id <= 0)
            {
                Console.WriteLine("ID không hợp lệ. Vui lòng nhập ID lớn hơn 0.");
                return null;
            }

            var nhanVien = nhanViens.Find(nv => nv.Id == id);
            if (nhanVien == null)
            {
                Console.WriteLine("Không tìm thấy nhân viên với ID này.");
            }
            return nhanVien;
        }
        public void TaoSanLuong(int id, CongDoan congDoan)
        {
            var nhanVien = TimKiemNhanVien(id);
            if (nhanVien != null && congDoan != null)
            {
                nhanVien.CongDoans.Add(congDoan);
            }
            else
            {
                Console.WriteLine("Nhân viên không tồn tại hoặc thông tin công đoạn không hợp lệ.");
            }
        }

        public void XuatBaoCao()
        {
            foreach (var nhanVien in nhanViens)
            {
                Console.WriteLine($"Nhân viên: {nhanVien.Ten}");
                Console.WriteLine($"Tổng lương: {nhanVien.TongLuong}");
                Console.WriteLine("Công đoạn đã làm:");
                foreach (var congDoan in nhanVien.CongDoans)
                {
                    Console.WriteLine($"- Mã công đoạn: {congDoan.MaCongDoan}, Tên công đoạn: {congDoan.TenCongDoan}, Số lượng sản phẩm: {congDoan.SoLuongSanPham}");
                }
                Console.WriteLine();
            }
        }
    }
}