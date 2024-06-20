using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.OOP.Buoi7.Bai4
{
    //chứa các thuộc tính và phương thức liên quan đến một sinh viên.
    public class SinhVien
    {
        private static int _idCounter = 0;
        public int Id { get; private set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double DiemTrungBinh { get; private set; }
        public string HocLuc { get; private set; }

        public SinhVien(string ten, string gioiTinh, int tuoi, double diemToan, double diemLy, double diemHoa)
        {
            Id = ++_idCounter;
            Ten = ten;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            TinhDiemTrungBinhVaHocLuc();
        }

        public void TinhDiemTrungBinhVaHocLuc()
        {
            DiemTrungBinh = (DiemToan + DiemLy + DiemHoa) / 3;
            if (DiemTrungBinh >= 8)
                HocLuc = "Giỏi";
            else if (DiemTrungBinh >= 6.5)
                HocLuc = "Khá";
            else if (DiemTrungBinh >= 5)
                HocLuc = "Trung Bình";
            else
                HocLuc = "Yếu";
        }

        public void CapNhatDiem(double diemToan, double diemLy, double diemHoa)
        {
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;
            TinhDiemTrungBinhVaHocLuc();
        }

        public override string ToString()
        {
            return $"ID: {Id}, Tên: {Ten}, Giới Tính: {GioiTinh}, Tuổi: {Tuoi}, Điểm TB: {DiemTrungBinh:F2}, Học Lực: {HocLuc}";
        }
    }
}
