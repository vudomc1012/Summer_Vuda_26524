using BE_26_05_Vuda.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_26_05_Vuda.DataAccess.DAL
{
    public interface IQuanLyNhanVien
    {
        void ThemNhanVien();
        NhanVien TimKiemNhanVien(int id);
        void TaoSanLuong(int id, CongDoan congDoan);
        void XuatBaoCao();

    }

}
