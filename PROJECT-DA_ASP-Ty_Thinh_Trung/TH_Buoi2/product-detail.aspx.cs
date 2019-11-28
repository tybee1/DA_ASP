using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BUS;
using DTO;
namespace TH_Buoi2
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadCTSP();
                ddlKichThuoc.DataSource = ChiTietSanPham_BUS.LoadDSDropdownList();
                ddlKichThuoc.DataTextField = "KICHCO";
                ddlKichThuoc.DataValueField = "MASP";
                ddlKichThuoc.DataBind();

                ddlMau.DataSource = ChiTietSanPham_BUS.LoadDSDropdownList();
                ddlMau.DataTextField = "MAUSAC";
                ddlMau.DataValueField = "MASP";
                ddlMau.DataBind();

            }
        }
        public void LoadCTSP()
        {
            int MASP = Convert.ToInt32(Request.QueryString["MASP"]);
            DataRow dr = ChiTietSanPham_BUS.LayCTSPTheoMa(MASP).Rows[0];
            SanPham_DTO sanPham_DTO = new SanPham_DTO();
            lblTenSanPham.Text = dr["TENSP"].ToString();
            lblTenSanPham2.Text = dr["TENSP"].ToString();
            lblMoTa.Text = dr["MOTA"].ToString();
            lblGiaTien.Text = Convert.ToString(dr["GIATIEN"]);
            imgHinhAnh.ImageUrl = "images/" + dr["HINHANH_1"];
        }

    

        protected void btnAddCat_Click(object sender, EventArgs e)
        {
            GioHang_DTO gh = new GioHang_DTO();
            gh.TENTK = "admin";
            gh.MASP = Convert.ToInt32(Request.QueryString["MASP"]);
            gh.SOLUONG = Convert.ToInt32(txtSoLuong.Text);
            if (GioHang_BUS.ThemGH(gh))
            {
                Response.Write("<script>alert('Thêm thành công')</script>");
            }
            else
            {
                Response.Write("<script>alert('Thêm thất bại')</script>");
            }
        }
    }
}