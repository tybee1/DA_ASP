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
    public partial class From_SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                grvSanPham.DataSource = SanPham_BUS.LayDSSanPham();
                grvSanPham.DataBind();
            }
        }

        protected void grvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnThemSanPham_Click(object sender, EventArgs e)
        {
            SanPham_DTO sanPham_DTO = new SanPham_DTO();
            sanPham_DTO.MASP1 = Convert.ToInt32(txtMaSanPham.Text);
            sanPham_DTO.TENSP1 = txtTenSanPham.Text;
            sanPham_DTO.MOTA1 = txtMoTa.Text;
            sanPham_DTO.LOAI1 = Convert.ToInt32(txtLoai.Text);
            sanPham_DTO.TRANGTHAI1 = chkTrangThai.Checked;
            if (SanPham_BUS.ThemSanPham(sanPham_DTO))
            {
                grvSanPham.DataSource = SanPham_BUS.LayDSSanPham();
                grvSanPham.DataBind();
            }
            else
            {
                Response.Write("<script>alert('Thêm tài khoản thất bại');</script>");
            }
        }
    }
}