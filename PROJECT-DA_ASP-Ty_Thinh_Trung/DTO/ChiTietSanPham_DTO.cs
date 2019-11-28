using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ChiTietSanPham_DTO
    {
        private int mASP;
        private int iD;
        private string mAUSAC;
        private int kICHCO;
        private float gIATIEN;
        private int tONKHO;
        private string hINHANH_1;
        private string hINHANH_2;
        private string hINHANH_3;
        private string tENSP;
        

  

      
        public int MASP { get => mASP; set => mASP = value; }
        public int ID { get => iD; set => iD = value; }
        public string MAUSAC { get => mAUSAC; set => mAUSAC = value; }
        public float GIATIEN { get => gIATIEN; set => gIATIEN = value; }
        public int TONKHO { get => tONKHO; set => tONKHO = value; }
        public string HINHANH_1 { get => hINHANH_1; set => hINHANH_1 = value; }
        public string HINHANH_2 { get => hINHANH_2; set => hINHANH_2 = value; }
        public string HINHANH_3 { get => hINHANH_3; set => hINHANH_3 = value; }
        public string TENSP { get => tENSP; set => tENSP = value; }
        public int KICHCO { get => kICHCO; set => kICHCO = value; }
      
    }
}
