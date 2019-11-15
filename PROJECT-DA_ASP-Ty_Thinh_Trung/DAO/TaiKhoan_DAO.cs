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
    public class TaiKhoan_DAO
    {
        public static List<TaiKhoan_DTO> LayDSTaiKhoan()
        {
            string query = "SELECT * FROM TAIKHOAN";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = DataProvider.ExecuteSelectQuery(query, sqlParameters);
            List<TaiKhoan_DTO> lsttaiKhoan = new List<TaiKhoan_DTO>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                lsttaiKhoan.Add(ConvertInto(dataRow));
            }
            return lsttaiKhoan;
        }
        public static TaiKhoan_DTO ConvertInto(DataRow dataRow)
        {
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.TENTK1 = dataRow["TENTK"].ToString();
            tk.MATKHAU1 = dataRow["MATKHAU"].ToString();
            tk.EMAIL1 = dataRow["EMAIL"].ToString();
            tk.SDT1 = dataRow["SDT"].ToString();
            tk.DIACHI1 = dataRow["DIACHI"].ToString();
            tk.HOTEN1 = dataRow["HOTEN"].ToString();
            tk.LAADMIN1 = Convert.ToBoolean(dataRow["LAADMIN"]);
            tk.ANHDAIDIEN1 = dataRow["ANHDAIDIEN"].ToString();
            tk.TRANGTHAI1 = Convert.ToBoolean(dataRow["TRANGTHAI"]);
            return tk;
        }
        public static String LayMatKhau(String TENTK)
        {
            string query = "SELECT MATKHAU FROM TAIKHOAN WHERE TENTK=@TENTK";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TENTK", TENTK);
            return DataProvider.ExecuteSelectQuery(query, sqlParameters).Rows[0][0].ToString();
        }
        public static bool KiemTraTaiKhoanTonTai(string TENTK)
        {
            string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENTK=@TENTK";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TENTK", TENTK);
            return Convert.ToInt32(DataProvider.ExecuteSelectQuery(query, sqlParameters).Rows[0][0]) == 1;
        }
        public static bool ThemTaiKhoan(TaiKhoan_DTO TENTK)
        {
            string query = "INSERT INTO TAIKHOAN(TENTK,MATKHAU,EMAIL,SDT,DIACHI,HOTEN,LAADMIN,ANHDAIDIEN,TRANGTHAI) VALUES(@TENTK,@MATKHAU,@EMAIL,@SDT,@DIACHI,@HOTEN,@LAADMIN,@ANHDAIDIEN,@TRANGTHAI)";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@TENTK", TENTK.TENTK1);
            sqlParameters[1] = new SqlParameter("@MATKHAU", TENTK.MATKHAU1);
            sqlParameters[2] = new SqlParameter("@EMAIL", TENTK.EMAIL1);
            sqlParameters[3] = new SqlParameter("@SDT", TENTK.SDT1);
            sqlParameters[4] = new SqlParameter("@DIACHI", TENTK.DIACHI1);
            sqlParameters[5] = new SqlParameter("@HOTEN", TENTK.HOTEN1);
            sqlParameters[6] = new SqlParameter("@LAADMIN", TENTK.LAADMIN1);
            sqlParameters[7] = new SqlParameter("@ANHDAIDIEN", TENTK.ANHDAIDIEN1);
            sqlParameters[8] = new SqlParameter("@TRANGTHAI", TENTK.TRANGTHAI1);
            return DataProvider.ExecuteInsertQuery(query, sqlParameters) == 1;
        }
        public static bool CapNhatTaiKhoan(TaiKhoan_DTO TENTK)
        {
            string query = "UPDATE TAIKHOAN SET MATKHAU=@MATKHAU,EMAIL=@EMAIL,SDT=@SDT,DIACHI=@DIACHI,HOTEN=@HOTEN,LAADMIN=@LAADMIN,ANHDAIDIEN=@ANHDAIDIEN,TRANGTHAI=@TRANGTHAI WHERE TENTK=@TENTK ";
            SqlParameter[] sqlParameters = new SqlParameter[9];
            sqlParameters[0] = new SqlParameter("@TENTK", TENTK.TENTK1);
            sqlParameters[1] = new SqlParameter("@MATKHAU", TENTK.MATKHAU1);
            sqlParameters[2] = new SqlParameter("@EMAIL", TENTK.EMAIL1);
            sqlParameters[3] = new SqlParameter("@SDT", TENTK.SDT1);
            sqlParameters[4] = new SqlParameter("@DIACHI", TENTK.DIACHI1);
            sqlParameters[5] = new SqlParameter("@HOTEN", TENTK.HOTEN1);
            sqlParameters[6] = new SqlParameter("@LAADMIN", TENTK.LAADMIN1);
            sqlParameters[7] = new SqlParameter("@ANHDAIDIEN", TENTK.ANHDAIDIEN1);
            sqlParameters[8] = new SqlParameter("@TRANGTHAI", TENTK.TRANGTHAI1);
            return DataProvider.ExecuteUpdateQuery(query, sqlParameters) == 1;
        }
        public static TaiKhoan_DTO LayThongTinTaiKhoan(string TENTK)
        {
            string query = "SELECT * FROM TAIKHOAN WHERE TENTK=@TENTK";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TENTK", TENTK);
            return ConvertInto(DataProvider.ExecuteSelectQuery(query, sqlParameters).Rows[0]);
        }
        public static bool XoaTaiKhoan(string TENTK)
        {
            string query = "UPDATE TAIKHOAN SET TRANGTHAI=0 WHERE TENTK=@TENTK";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TENTK", TENTK);
            return DataProvider.ExecuteUpdateQuery(query, sqlParameters) == 1;
        }
        
    }

}

