using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class HoaDon_DAO
    {
        public static List<HoaDon_DTO> LayDanhSachHoaDon()
        {
            string query = "SELECT * FROM HOADON";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dt = DataProvider.ExecuteSelectQuery(query, sqlParameters);
            List<HoaDon_DTO> HoaDonList = new List<HoaDon_DTO>();
            foreach (DataRow dr in dt.Rows)
            {
                HoaDonList.Add(ConverInTo(dr));
            }
            return HoaDonList;
        }
        public static HoaDon_DTO ConverInTo(DataRow dr)
        {
            HoaDon_DTO hoaDon_DTO = new HoaDon_DTO();
            hoaDon_DTO.MAHD1 = Convert.ToInt32(dr["MAHD"]);
            hoaDon_DTO.MAKH1 = Convert.ToInt32(dr["MAKH"]);
            hoaDon_DTO.NGAYLAP1 = dr["NGAYLAP"].ToString();
            hoaDon_DTO.NGAYMUA1 = dr["NGAYMUA"].ToString();
            hoaDon_DTO.SDTGIAOHANG1 = dr["SDTGIAOHANG"].ToString();
            hoaDon_DTO.TONGTIEN1 = Convert.ToInt32(dr["TONGTIEN"]);
            hoaDon_DTO.DIACHIGIAOHANG1 = dr["DIACHIGIAO"].ToString();
            hoaDon_DTO.TRANGTHAI1 = Convert.ToBoolean(dr["TRANGTHAI"]);
            return hoaDon_DTO;
        }
        public static bool ThemHoaDon(HoaDon_DTO hoaDon_DTO)
        {
            string query = "INSERT INTO HOADON(MAHD,MAKH,NGAYLAP,NGAYMUA,SDTGIAOHANG,TONGTIEN,DIACHIGIAO,TRANGTHAI) VALUES(@MAHD,@MAKH,@NGAYLAP,@NGAYMUA,@SDTGIAOHANG,@TONGTIEN,@DIACHIGIAO,@TRANGTHAI)";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@MAHD", hoaDon_DTO.MAHD1);
            sqlParameters[1] = new SqlParameter("@MAKH", hoaDon_DTO.MAKH1);
            sqlParameters[2] = new SqlParameter("@NGAYLAP", hoaDon_DTO.NGAYLAP1);
            sqlParameters[3] = new SqlParameter("@NGAYMUA", hoaDon_DTO.NGAYMUA1);
            sqlParameters[4] = new SqlParameter("@SDTGIAOHANG", hoaDon_DTO.SDTGIAOHANG1);
            sqlParameters[5] = new SqlParameter("@TONGTIEN", hoaDon_DTO.TONGTIEN1);
            sqlParameters[6] = new SqlParameter("@DIACHIGIAO", hoaDon_DTO.DIACHIGIAOHANG1);
            sqlParameters[7] = new SqlParameter("@TRANGTHAI", hoaDon_DTO.TRANGTHAI1);
            return DataProvider.ExecuteInsertQuery(query, sqlParameters) == 1;
        }
        public static bool KTMAHDTONTAI(int MAHD)
        {
            string query= "SELECT COUNT(*) FROM HOADON WHERE MAHD=@MAHD";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MAHD", MAHD);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, sqlParameters).Rows[0][0]) == 1;
        }
        public static HoaDon_DTO LayThongTinHoaDon(int MAHD)
        {
            string query = "SELECT * FROM HOADON WHERE MAHD=@MAHD";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MAHD", MAHD);
            return ConverInTo(DataProvider.ExecuteSelectQuery(query, sqlParameters).Rows[0]);
        }
        public static bool CapNhatHoaDon(HoaDon_DTO hoaDon_DTO)
        {
            string query = "UPDATE HOADON SET MAKH=@MAKH,NGAYLAP=@NGAYLAP,NGAYMUA=@NGAYMUA,SDTGIAOHANG=@SDTGIAOHANG,TONGTIEN=@TONGTIEN,DIACHIGIAO=@DIACHIGIAO,TRANGTHAI=@TRANGTHAI WHERE MAHD=@MAHD";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@MAHD", hoaDon_DTO.MAHD1);
            sqlParameters[1] = new SqlParameter("@MAKH", hoaDon_DTO.MAKH1);
            sqlParameters[2] = new SqlParameter("@NGAYLAP", hoaDon_DTO.NGAYLAP1);
            sqlParameters[3] = new SqlParameter("@NGAYMUA", hoaDon_DTO.NGAYMUA1);
            sqlParameters[4] = new SqlParameter("@SDTGIAOHANG", hoaDon_DTO.SDTGIAOHANG1);
            sqlParameters[5] = new SqlParameter("@TONGTIEN", hoaDon_DTO.TONGTIEN1);
            sqlParameters[6] = new SqlParameter("@DIACHIGIAO", hoaDon_DTO.DIACHIGIAOHANG1);
            sqlParameters[7] = new SqlParameter("@TRANGTHAI", hoaDon_DTO.TRANGTHAI1);
            return DataProvider.ExecuteInsertQuery(query, sqlParameters) == 1;
        }
        public static bool XoaHoaDon(int MAHD)
        {
            string query = "UPDATE HOADON SET TRANGTHAI=0 WHERE MAHD=@MAHD";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MAHD", MAHD);
            return DataProvider.ExecuteUpdateQuery(query, sqlParameters) == 1;
        }
    }
}
