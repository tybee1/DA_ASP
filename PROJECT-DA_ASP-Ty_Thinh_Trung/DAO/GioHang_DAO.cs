using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
   public class GioHang_DAO
    {
        public static DataTable LayGH(string TENTK)
        {
            string query = "SELECT ctsp.HINHANH_1,gh.MASP,sp.TENSP,ctsp.GIATIEN,SOLUONG,GIATIEN * SOLUONG AS TONGTIEN FROM GIOHANG gh,CHITIETSANPHAM ctsp,SANPHAM sp WHERE ctsp.MASP=gh.MASP AND sp.MASP=ctsp.MASP AND TENTK=@TENTK ";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TENTK", TENTK);
            return DataProvider.ExecuteSelectQuery(query, sqlParameters);
        }
        public static bool KTGIOTONTAI(GioHang_DTO gh)
        {
            string query = "SELECT COUNT(*) FROM GIOHANG WHERE TENTK=@TENTK AND MASP=@MASP";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TENTK", gh.TENTK);
            sqlParameters[1] = new SqlParameter("@MASP", gh.MASP);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, sqlParameters).Rows[0][0]) == 1;
        }
        public static bool ThemGH(GioHang_DTO gh)
        {
            string query = "INSERT INTO GIOHANG (TENTK, MASP, SOLUONG) VALUES (@TENTK, @MASP, @SOLUONG)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@TENTK", gh.TENTK);
            sqlParameters[1] = new SqlParameter("@MASP", gh.MASP);
            sqlParameters[2] = new SqlParameter("@SOLUONG", gh.SOLUONG);
            return DataProvider.ExecuteInsertQuery(query, sqlParameters) == 1;
        }
        public static bool SuaGH(GioHang_DTO gh)
        {
            string query = "UPDATE GIOHANG SET SOLUONG = SOLUONG + @SOLUONG WHERE TENTK = @TENTK AND MASP = @MASP";
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TENTK", gh.TENTK);
            param[1] = new SqlParameter("@MASP", gh.MASP);
            param[2] = new SqlParameter("@SOLUONG", gh.SOLUONG);
            return DataProvider.ExecuteUpdateQuery(query, param) == 1;
        }
        public static GioHang_DTO ConvertInto(DataRow dr)
        {
            GioHang_DTO gh = new GioHang_DTO();
            gh.TENTK = dr["TENTK"].ToString();
            gh.MASP = Convert.ToInt32(dr["MASP"]);
            gh.SOLUONG = Convert.ToInt32(dr["SOLUONG"]);
            return gh;
        }
    }
}
