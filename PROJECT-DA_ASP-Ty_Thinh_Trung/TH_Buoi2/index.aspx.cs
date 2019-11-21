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
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlTimKiem.DataSource = SanPham_BUS.LoadDSDprodownList();
                ddlTimKiem.DataValueField = "ID1";
                ddlTimKiem.DataTextField = "TENLOAI1";
                //ddlTimKiem.AutoPostBack = true;
                ddlTimKiem.DataBind();
                LoadDSSanPham();
            }
        }
        public void LoadDSSanPham()
        {
            rptSanPham.DataSource = ChiTietSanPham_BUS.LayDSSanPham();
            rptSanPham.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }

        protected void ddlTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID = ddlTimKiem.SelectedIndex;
            rptSanPham.DataSource = SanPham_BUS.LoadDSLOAISP(ID);
            rptSanPham.DataBind();
        }

 

        protected void rptSanPham_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
         if(e.CommandName== "XemCT")
            {
                ChiTietSanPham_DTO CT = new ChiTietSanPham_DTO();   
                CT.TENSP = e.CommandArgument.ToString();
                CT.MASP = Convert.ToInt32(e.CommandArgument);
                if(ChiTietSanPham_BUS.LayCTSPTheoMa(CT))
                {
                    Response.Write("<script>alert('Thêm thành công')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Thêm thất bại')</script>");
                }
            }
        }

        protected void lbtChiTietSanPham_Click(object sender, EventArgs e)
        {
            Response.Redirect("product-detail.aspx");
            
        }
    }
}