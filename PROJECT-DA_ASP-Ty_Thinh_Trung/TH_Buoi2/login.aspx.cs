using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
namespace TH_Buoi2
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string TENTK = txtTenDangNhap.Text;
            string MATKHAU = txtMatKhau.Text;
            if(TaiKhoan_BUS.KTDangNhap(TENTK,MATKHAU))
            {
                HttpCookie cookie = new HttpCookie("TENTK1");
                cookie.Value = TENTK;
                cookie.Expires = DateTime.Now.AddDays(14);
                Response.Cookies.Add(cookie);
                Response.Redirect("ChiTietSanPham.aspx");
            }
            else
            {
                Response.Write("<script>alert('Đăng nhập thất bại');</script>");
            }
        }
    }
}