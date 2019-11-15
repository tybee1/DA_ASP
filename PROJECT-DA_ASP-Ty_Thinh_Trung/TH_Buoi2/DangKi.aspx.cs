using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DTO;
using BUS;
namespace TH_Buoi2
{
    public partial class DangKi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            chkTrangThai.Checked = true;
        }

        protected void btnDangKi_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                TaiKhoan_DTO dk = new TaiKhoan_DTO();
                dk.TENTK1 = txtTenTaiKhoan.Text;
                dk.MATKHAU1 = txtMatKhau.Text;
                dk.EMAIL1 = txtEmail.Text;
                dk.SDT1 = txtSDT.Text;
                dk.DIACHI1 = txtDiaChi.Text;
                dk.HOTEN1 = txtHoTen.Text;
                dk.LAADMIN1 = chkLaAdmin.Checked;
                dk.ANHDAIDIEN1 = txtAnh.Text;
                dk.TRANGTHAI1 = chkTrangThai.Checked;
                if (TaiKhoan_BUS.ThemTaiKhoan(dk))
                {
                    Response.Redirect("login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Thêm tài khoản thất bại');</script>");
                }
            }
        }

        protected void cuvDiaChi_ServerValidate(object source, ServerValidateEventArgs args)
        {
           
        }
    }
}