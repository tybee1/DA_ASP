using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class TaiKhoan_BUS
    {
        public static bool KTDangNhap(string TENTK,string MATKHAU)
        {
            if(!TaiKhoan_DAO.KiemTraTaiKhoanTonTai(TENTK))            
                return false;
            return MATKHAU ==TaiKhoan_DAO.LayMatKhau(TENTK);   
        }
        public static List<TaiKhoan_DTO> LayDSTaiKhoan()
        {
            return TaiKhoan_DAO.LayDSTaiKhoan();
        }
        public static bool ThemTaiKhoan(TaiKhoan_DTO tk)
        {
            if (TaiKhoan_DAO.KiemTraTaiKhoanTonTai(tk.TENTK1))
                return false;
            return TaiKhoan_DAO.ThemTaiKhoan(tk);
        }
        public static bool CapNhatTaiKhoan(TaiKhoan_DTO tk)
        {
            if (!TaiKhoan_DAO.KiemTraTaiKhoanTonTai(tk.TENTK1))
                return false;
            return TaiKhoan_DAO.CapNhatTaiKhoan(tk);
        }
        public static TaiKhoan_DTO LayThongTinTaiKhoan(string tk)
        {
            if (!TaiKhoan_DAO.KiemTraTaiKhoanTonTai(tk))
                return null;
            return TaiKhoan_DAO.LayThongTinTaiKhoan(tk);
        }
        public static bool XoaTaiKhoan(string tk)
        {
            if (!TaiKhoan_DAO.KiemTraTaiKhoanTonTai(tk))
                return false;
            return TaiKhoan_DAO.XoaTaiKhoan(tk);
        }
     
}
