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
    public class SanPham_DAO
    {
        public static List<SanPham_DTO> LayDSSanPham()
        {
            string query = "SELECT * FROM SANPHAM";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbSP = DataProvider.ExecuteSelectQuery(query, param);
            List<SanPham_DTO> lstTK = new List<SanPham_DTO>();
            foreach (DataRow dr in dtbSP.Rows)
            {
                lstTK.Add(ConvertToDTO(dr));
            }
            return lstTK;
        }
        public static List<SanPham_DTO> LayDSSanPham2()
        {
            string query = "SELECT * FROM LOAISP";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtbKetQua = DataProvider.ExecuteSelectQuery(query, param);
            List<SanPham_DTO> lstSanPham = new List<SanPham_DTO>();
            foreach (DataRow dr in dtbKetQua.Rows)
            {
                lstSanPham.Add(ConvertToDTO2(dr));
            }
            return lstSanPham;
        }
        public static SanPham_DTO ConvertToDTO2(DataRow dr)
        {
            SanPham_DTO sanPham_DTO = new SanPham_DTO();
            sanPham_DTO.ID1 =Convert.ToInt32(dr["ID"]);
            sanPham_DTO.TENLOAI1 = dr["TENLOAI"].ToString();
            return sanPham_DTO;
        }
            public static SanPham_DTO ConvertToDTO(DataRow dr)
        {
            SanPham_DTO sanPham_DTO= new SanPham_DTO();
            sanPham_DTO.MASP1 = Convert.ToInt32(dr["MASP"]);
            sanPham_DTO.TENSP1 = dr["TENSP"].ToString();
            sanPham_DTO.MOTA1 = dr["MOTA"].ToString();
            sanPham_DTO.LOAI1 = Convert.ToInt32(dr["LOAI"]);
            sanPham_DTO.TRANGTHAI1 = Convert.ToBoolean(dr["TRANGTHAI"]);
            return sanPham_DTO;
        }
        public static bool KTMASPTONTAI(int MASP)
        {
            string query = "SELECT COUNT(*) FROM SANPHAM WHERE MASP=@MASP";
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@MASP", MASP);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, sqlParameter).Rows[0][0]) == 1;
        }
        public static bool ThemSanPham(SanPham_DTO sanPham_DTO)
        {
            string query = "INSERT INTO SANPHAM(MASP,TENSP,MOTA,LOAI,TRANGTHAI) VALUES(@MASP,@TENSP,@MOTA,@LOAI,@TRANGTHAI)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@MASP", sanPham_DTO.MASP1);
            sqlParameters[1] = new SqlParameter("@TENSP", sanPham_DTO.TENSP1);
            sqlParameters[2] = new SqlParameter("@MOTA", sanPham_DTO.MOTA1);
            sqlParameters[3] = new SqlParameter("@LOAI", sanPham_DTO.LOAI1);
            sqlParameters[4] = new SqlParameter("@TRANGTHAI", sanPham_DTO.TRANGTHAI1);
            return DataProvider.ExecuteInsertQuery(query, sqlParameters) == 1;

        }
        public static SanPham_DTO LayThongTinSanPham(int MASP)
        {
            string query = "SELECT * FROM SANPHAM WHERE MASP=@MASP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MASP", MASP);
            return ConvertToDTO(DataProvider.ExecuteSelectQuery(query, sqlParameters).Rows[0]);
        }
        public static bool CapNhatSanPham(SanPham_DTO sanPham_DTO)
        {
            string query = "UPDATE SANPHAM SET TENSP=@TENSP,MOTA=@MOTA,LOAI=@LOAI,TRANGTHAI=@TRANGTHAI WHERE MASP=@MASP";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@MASP", sanPham_DTO.MASP1);
            sqlParameters[1] = new SqlParameter("@TENSP", sanPham_DTO.TENSP1);
            sqlParameters[2] = new SqlParameter("@MOTA", sanPham_DTO.MOTA1);
            sqlParameters[3] = new SqlParameter("@LOAI", sanPham_DTO.LOAI1);
            sqlParameters[4] = new SqlParameter("@TRANGTHAI", sanPham_DTO.TRANGTHAI1);
            return DataProvider.ExecuteUpdateQuery(query, sqlParameters) == 1;
        }
        public static bool XoaSanPham(int MASP)
        {
            string query = "UPDATE SANPHAM SET TRANGTHAI= 0 WHERE MASP=@MASP";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MASP", MASP);
            return DataProvider.ExecuteUpdateQuery(query, sqlParameters) == 1;
        }
    }
}
