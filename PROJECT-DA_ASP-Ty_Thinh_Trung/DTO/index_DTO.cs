﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class index_DTO
    {
        private string maSP;
        private string tenSP;
        private string thongTin;
        private int giaTien;
        private int soLuongTonKho;
        private string maLoaiSP;
        private string anhMinhHoa;
        private bool trangThai;
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string ThongTin { get => thongTin; set => thongTin = value; }
        public int GiaTien { get => giaTien; set => giaTien = value; }
        public int SoLuongTonKho { get => soLuongTonKho; set => soLuongTonKho = value; }
        public string MaLoaiSP { get => maLoaiSP; set => maLoaiSP = value; }
        public string AnhMinhHoa { get => anhMinhHoa; set => anhMinhHoa = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public index_DTO()
        {
            GiaTien = 0;
            SoLuongTonKho = 0;
            TrangThai = true;
        }
    }
}

