using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietSanPham_BUS
    {
        public static DataTable LayDSSanPham()
        {
            return ChiTietSanPham_DAO.LayDSSanPham();
        }
        public static DataTable LayCTSPTheoMa(int MASP)
        {
            
            return ChiTietSanPham_DAO.LayCTSPTheoMa(MASP);
        }
        public static List<ChiTietSanPham_DTO> LoadDSDropdownList()
        {
            return ChiTietSanPham_DAO.LoadDSDropdownList();
        }
    }
}
