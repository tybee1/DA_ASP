using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDon_BUS
    {
        public static List<HoaDon_DTO> LayDanhSachHoaDon()
        {
            return HoaDon_DAO.LayDanhSachHoaDon();
        }
        public static bool ThemHoaDon(HoaDon_DTO hoaDon_DTO)
        {
            if(HoaDon_DAO.KTMAHDTONTAI(hoaDon_DTO.MAHD1))
                return false;
            return HoaDon_DAO.ThemHoaDon(hoaDon_DTO);
        }
        public static HoaDon_DTO LayThongTinHoaDon(int MAHD)
        {
            if (!HoaDon_DAO.KTMAHDTONTAI(MAHD))
                return null;
            return HoaDon_DAO.LayThongTinHoaDon(MAHD);
        }
        public static bool XoaHoaDon(int MAHD)
        {
            if (!HoaDon_DAO.KTMAHDTONTAI(MAHD))
                return false;
            return HoaDon_DAO.XoaHoaDon(MAHD);
        }
        public static bool CapNhatHoaDon(HoaDon_DTO hoaDon_DTO)
        {
            if (!HoaDon_DAO.KTMAHDTONTAI(hoaDon_DTO.MAHD1))
                return false;
            return HoaDon_DAO.CapNhatHoaDon(hoaDon_DTO);
        }
    }
}
