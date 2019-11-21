using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;
namespace TH_Buoi2
{
    public partial class HoaDon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CalNgayLap.Visible = false;
                CalNgayMua.Visible = false;
                LoadDSHoaDon();
            }
        }
        public void LoadDSHoaDon()
        {
            grvHoaDon.DataSource = HoaDon_BUS.LayDanhSachHoaDon();
            grvHoaDon.DataBind();
        }

        protected void ibtCal_Click(object sender, ImageClickEventArgs e)
        {
            if (CalNgayLap.Visible==true)
            {
                CalNgayLap.Visible = false;
            }
            else
            {
                CalNgayLap.Visible = true;
            }
           

        }

        protected void CalNgaySinh_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayLap.Text = CalNgayLap.SelectedDate.ToString("dd/MM/yyyy");

        }

        protected void CalNgayMua_SelectionChanged(object sender, EventArgs e)
        {
            txtNgayMua.Text = CalNgayMua.SelectedDate.ToString("dd/MM/yyyy");

        }

        protected void ibtNgayMua_Click(object sender, ImageClickEventArgs e)
        {
            if (CalNgayMua.Visible==true)
            {
                CalNgayMua.Visible = false;
            }
            else
            {
                CalNgayMua.Visible=true;
            }
           
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon_DTO hoaDon_DTO = new HoaDon_DTO();
            hoaDon_DTO.MAHD1 =Convert.ToInt32(txtMaHoaDon.Text);
            hoaDon_DTO.MAKH1 = Convert.ToInt32(txtMaKhachHang.Text);
            hoaDon_DTO.NGAYLAP1 = txtNgayLap.Text;
            hoaDon_DTO.NGAYMUA1 = txtNgayMua.Text;
            hoaDon_DTO.SDTGIAOHANG1 = txtSDT.Text;
            hoaDon_DTO.TONGTIEN1 = Convert.ToInt32(txtTongTien.Text);
            hoaDon_DTO.DIACHIGIAOHANG1 = txtDiaChiGiaoHang.Text;
            hoaDon_DTO.TRANGTHAI1 = chkTrangThai.Checked;
            if(HoaDon_BUS.ThemHoaDon(hoaDon_DTO))
            {
                LoadDSHoaDon();
            }
            else
            {
                Response.Write("<script>alert('Thêm hóa đơn thất bại');</script>");
            }
        }

        protected void grvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        protected void grvHoaDon_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="ChonHD")
            {
                int MAHD =Convert.ToInt32(e.CommandArgument.ToString());
                HoaDon_DTO hoaDon_DTO = HoaDon_BUS.LayThongTinHoaDon(MAHD);
                if(hoaDon_DTO!=null)
                {
                    txtMaHoaDon.Text = Convert.ToString(hoaDon_DTO.MAHD1);
                    txtMaKhachHang.Text =Convert.ToString(hoaDon_DTO.MAKH1);
                    txtNgayLap.Text = hoaDon_DTO.NGAYLAP1;
                    txtNgayMua.Text = hoaDon_DTO.NGAYMUA1;
                    txtSDT.Text =hoaDon_DTO.SDTGIAOHANG1;
                    txtTongTien.Text = Convert.ToString(hoaDon_DTO.TONGTIEN1);
                    txtDiaChiGiaoHang.Text = hoaDon_DTO.DIACHIGIAOHANG1;
                    chkTrangThai.Checked = hoaDon_DTO.TRANGTHAI1;
                }
            }
            if(e.CommandName=="XoaHD")
            {
                int MAHD = Convert.ToInt32(e.CommandArgument.ToString());
               if(HoaDon_BUS.XoaHoaDon(MAHD))
                {
                    LoadDSHoaDon();
                }
                else
                {
                    Response.Write("<script>alert('Xoá hóa đơn thất bại');</script>");
                }
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            HoaDon_DTO hoaDon_DTO = new HoaDon_DTO();
            hoaDon_DTO.MAHD1 = Convert.ToInt32(txtMaHoaDon.Text);
            hoaDon_DTO.MAKH1 = Convert.ToInt32(txtMaKhachHang.Text);
            hoaDon_DTO.NGAYLAP1 = txtNgayLap.Text;
            hoaDon_DTO.NGAYMUA1 = txtNgayMua.Text;
            hoaDon_DTO.SDTGIAOHANG1 = txtSDT.Text;
            hoaDon_DTO.TONGTIEN1 = Convert.ToInt32(txtTongTien.Text);
            hoaDon_DTO.DIACHIGIAOHANG1 = txtDiaChiGiaoHang.Text;
            hoaDon_DTO.TRANGTHAI1 = chkTrangThai.Checked;
            if (HoaDon_BUS.CapNhatHoaDon(hoaDon_DTO))
            {
                LoadDSHoaDon();
            }
            else
            {
                Response.Write("<script>alert('Thêm hóa đơn thất bại');</script>");
            }
        }
    }
}