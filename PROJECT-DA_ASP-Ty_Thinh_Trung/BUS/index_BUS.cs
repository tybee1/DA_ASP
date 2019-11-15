using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace BUS
{
   public class index_BUS
    {
        public static DataTable LayDSSanPham()
        {
            return index_DAO.LayDSSanPham();
        }
    }
}
