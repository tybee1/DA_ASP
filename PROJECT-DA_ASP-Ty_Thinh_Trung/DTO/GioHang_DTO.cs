using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class GioHang_DTO
    {
        private int mASP;
        private string tENTK;
        private int sOLUONG;

        public int MASP { get => mASP; set => mASP = value; }
        public string TENTK { get => tENTK; set => tENTK = value; }
        public int SOLUONG { get => sOLUONG; set => sOLUONG = value; }
    }
}
