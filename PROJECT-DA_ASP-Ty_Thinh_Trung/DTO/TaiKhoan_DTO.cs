using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TaiKhoan_DTO
    {
        private string TENTK;
        private string MATKHAU;
        private string EMAIL;
        private string SDT;
        private string DIACHI;
        private string HOTEN;
        private bool LAADMIN;
        private string ANHDAIDIEN;
        private bool TRANGTHAI;

        public string TENTK1 { get => TENTK; set => TENTK = value; }
        public string MATKHAU1 { get => MATKHAU; set => MATKHAU = value; }
        public string EMAIL1 { get => EMAIL; set => EMAIL = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string DIACHI1 { get => DIACHI; set => DIACHI = value; }
        public bool LAADMIN1 { get => LAADMIN; set => LAADMIN = value; }
        public string ANHDAIDIEN1 { get => ANHDAIDIEN; set => ANHDAIDIEN = value; }
        public bool TRANGTHAI1 { get => TRANGTHAI; set => TRANGTHAI = value; }
        public string HOTEN1 { get => HOTEN; set => HOTEN = value; }

        public TaiKhoan_DTO()
        {
            this.LAADMIN1 = true;
            this.TRANGTHAI1 = true;
            this.ANHDAIDIEN1 = "";
        }
    }
}
