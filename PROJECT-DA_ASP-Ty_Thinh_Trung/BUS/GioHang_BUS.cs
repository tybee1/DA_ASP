using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

namespace BUS
{
   public class GioHang_BUS
    {
        public static DataTable LayGH(string TENTK)
        {
            return GioHang_DAO.LayGH(TENTK);
        }
        public static int TinhTongTienGH(string TENTK)
        {
            DataTable dt = GioHang_DAO.LayGH(TENTK);
            int tongtien = 0;
            foreach(DataRow dr in dt.Rows)
            {
                tongtien += Convert.ToInt32(dr["TONGTIEN"]);
            }
            return tongtien;
        }
        public static bool ThemGH(GioHang_DTO gh)
        {
            if (GioHang_DAO.KTGIOTONTAI(gh))
                return GioHang_DAO.SuaGH(gh);
            return GioHang_DAO.ThemGH(gh);
            
        }
    }
}
