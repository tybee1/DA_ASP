using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private int MAHD;
        private string NGAYLAP;
        private float TONGTIEN;
        private bool TRANGTHAI;
        private int MAKH;
        private string NGAYMUA;
        private string DIACHIGIAOHANG;
        private string SDTGIAOHANG;

        public int MAHD1 { get => MAHD; set => MAHD = value; }
        public string NGAYLAP1 { get => NGAYLAP; set => NGAYLAP = value; }
        public float TONGTIEN1 { get => TONGTIEN; set => TONGTIEN = value; }
        public bool TRANGTHAI1 { get => TRANGTHAI; set => TRANGTHAI = value; }
        public int MAKH1 { get => MAKH; set => MAKH = value; }
        public string NGAYMUA1 { get => NGAYMUA; set => NGAYMUA = value; }
        public string DIACHIGIAOHANG1 { get => DIACHIGIAOHANG; set => DIACHIGIAOHANG = value; }
        public string SDTGIAOHANG1 { get => SDTGIAOHANG; set => SDTGIAOHANG = value; }
    }
}
