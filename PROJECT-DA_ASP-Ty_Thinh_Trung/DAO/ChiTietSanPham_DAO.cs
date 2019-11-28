using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class ChiTietSanPham_DAO
    {
        public static DataTable LayDSSanPham()
        {
            string query = "SELECT * FROM SANPHAM,CHITIETSANPHAM WHERE SANPHAM.MASP=CHITIETSANPHAM.MASP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, sqlParameters);
        }
        public static DataTable LayCTSPTheoMa(int MASP)
        {
            string query = "SELECT * FROM SANPHAM,CHITIETSANPHAM WHERE SANPHAM.MASP=CHITIETSANPHAM.MASP AND SANPHAM.MASP=@MASP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MASP", MASP);
            return DataProvider.ExecuteSelectQuery(query, sqlParameters);
        }
        public static List<ChiTietSanPham_DTO> LoadDSDropdownList()
        {
            string query = "SELECT * FROM SANPHAM,CHITIETSANPHAM WHERE SANPHAM.MASP=CHITIETSANPHAM.MASP";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = DataProvider.ExecuteSelectQuery(query, sqlParameters);
            List<ChiTietSanPham_DTO> CTList = new List<ChiTietSanPham_DTO>();
            foreach(DataRow dr in dt.Rows)
            {
                CTList.Add(ConvertToCTSP(dr));
            }
            return CTList;
        }
        public static ChiTietSanPham_DTO ConvertToCTSP(DataRow dr)
        {
            ChiTietSanPham_DTO CT = new ChiTietSanPham_DTO();
            CT.ID = Convert.ToInt32(dr["ID"]);
            CT.MASP = Convert.ToInt32(dr["MASP"]);
            //CT.SIZE_XL = Convert.ToInt32(dr["SIZE_XL"]);
            //CT.SIZE_M = Convert.ToInt32(dr["SIZE_M"]);
            //CT.SIZE_L = Convert.ToInt32(dr["SIZE_X"]);
            CT.KICHCO = Convert.ToInt32(dr["KICHCO"]);
            CT.MAUSAC = dr["MAUSAC"].ToString();
            CT.TENSP = dr["TENSP"].ToString();
            CT.TONKHO = Convert.ToInt32(dr["TONKHO"]);
            CT.GIATIEN = Convert.ToInt32(dr["GIATIEN"]);
            CT.HINHANH_1 = dr["HINHANH_1"].ToString();
            CT.HINHANH_2 = dr["HINHANH_2"].ToString();
            CT.HINHANH_3 = dr["HINHANH_3"].ToString();
            return CT;
        }
        
    }
}
