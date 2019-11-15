using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham_DTO
    {
        private int MASP;
        private string TENSP;
        private string MOTA;
        private int LOAI;
        private bool TRANGTHAI;
        private string TENLOAI;
        private int ID;

        public int MASP1 { get => MASP; set => MASP = value; }
        public string TENSP1 { get => TENSP; set => TENSP = value; }
        public string MOTA1 { get => MOTA; set => MOTA = value; }
        public int LOAI1 { get => LOAI; set => LOAI = value; }
        public bool TRANGTHAI1 { get => TRANGTHAI; set => TRANGTHAI = value; }
        public string TENLOAI1 { get => TENLOAI; set => TENLOAI = value; }
        public int ID1 { get => ID; set => ID = value; }

        public SanPham_DTO()
        {
            TRANGTHAI = true;
        }
    }
}
