using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class SanPham_BUS
    {
        public static List<SanPham_DTO> LayDSSanPham()
        {
            return SanPham_DAO.LayDSSanPham();
        }
        public static bool ThemSanPham(SanPham_DTO sanPham_DTO)
        {
            if(SanPham_DAO.KTMASPTONTAI(sanPham_DTO.MASP1))
            {
                return false;
            }else
            {
                return SanPham_DAO.ThemSanPham(sanPham_DTO);
            }
        }
        public static List<SanPham_DTO> LoadDSDprodownList()
        {
            return SanPham_DAO.LoadDSDprodownList();
        }
        public static List<SanPham_DTO> LoadDSLOAISP(int ID)
        {
            return SanPham_DAO.LoadDSLOAISP(ID);
        }
            public static bool CapNhatSanPham(SanPham_DTO sanPham_DTO)
        {
            if (!SanPham_DAO.KTMASPTONTAI(sanPham_DTO.MASP1))
                return false;
            return SanPham_DAO.CapNhatSanPham(sanPham_DTO);
        }
        public static SanPham_DTO LayThongTinSanPham(int MASP)
        { 
            if (!SanPham_DAO.KTMASPTONTAI(MASP))
                return null;
            return SanPham_DAO.LayThongTinSanPham(MASP);
        }
        public static bool XoaSanPham(int MASP)
        {
            if (!SanPham_DAO.KTMASPTONTAI(MASP))
            {
                return false;
            }
            else
            {
                return SanPham_DAO.XoaSanPham(MASP);
            }

        }
      
    }
}
