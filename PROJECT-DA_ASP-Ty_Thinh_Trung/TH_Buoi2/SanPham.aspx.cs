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
    public partial class SanPham1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDanhSachSanPham();
                DropDownList1.DataSource = SanPham_BUS.LoadDSDprodownList();
                DropDownList1.DataValueField = "ID1";
                DropDownList1.DataTextField = "TENLOAI1";
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    string Loai = DropDownList1.SelectedValue;
        //    grvSanPham.DataSource = SanPham_BUS.LayDSSanPham2(Loai);
        //    grvSanPham.DataBind();
        }
        public void LoadDanhSachSanPham()
        {
            grvSanPham.DataSource = SanPham_BUS.LayDSSanPham();
            grvSanPham.DataBind();
        }

        //protected void btnThemSanPham_Click(object sender, EventArgs e)
        //{
           
        //}

        protected void btnThemSanPham_Click1(object sender, EventArgs e)
        {
            
                SanPham_DTO sp = new SanPham_DTO();
                sp.MASP1 = Convert.ToInt32(txtMaSanPham.Text);
                sp.TENSP1 = txtTenSanPham.Text;
                sp.MOTA1 = txtMoTa.Text;
                sp.LOAI1 = Convert.ToInt32(DropDownList1.SelectedValue);
                sp.TRANGTHAI1 = chkTrangThai.Checked;
                if (SanPham_BUS.ThemSanPham(sp))
                {
                    LoadDanhSachSanPham();
                }
                else
                {
                    Response.Write("<script>alert('Thêm sản phẩm thất bại');</script>");
                }
            

        }

        protected void btnChon_Command(object sender, CommandEventArgs e)
        {

        }

        protected void grvSanPham_RowCommand(object sender, GridViewCommandEventArgs e)
        {        

            if (e.CommandName == "ChonSP")
            {
                chkTrangThai.Enabled = false;
                txtMaSanPham.Enabled = false;
                int MASP =Convert.ToInt32(e.CommandArgument.ToString());
                SanPham_DTO sp = SanPham_BUS.LayThongTinSanPham(MASP);
                if(sp != null)
                {
                   
                    txtMaSanPham.Text =Convert.ToString(sp.MASP1);
                    txtTenSanPham.Text = sp.TENSP1;
                    txtMoTa.Text = sp.MOTA1;
                    DropDownList1.SelectedValue = Convert.ToString(sp.LOAI1);
                    chkTrangThai.Checked = sp.TRANGTHAI1;
                }
            }
            if (e.CommandName == "XoaSP")
            {
                int MASP = Convert.ToInt32(e.CommandArgument.ToString());
                if (SanPham_BUS.XoaSanPham(MASP))
                {
                   LoadDanhSachSanPham();
                    XoaForm();
                }
                else
                {
                    Response.Write("<script>alert('Xoá tài khoản thất bại');</script>");
                }
            }
        }

        protected void btnCapNhat_Click(object sender, EventArgs e)
        {
            chkTrangThai.Enabled = true;
            SanPham_DTO sp = new SanPham_DTO();
            sp.MASP1 = Convert.ToInt32(txtMaSanPham.Text);
            sp.TENSP1 = txtTenSanPham.Text;
            sp.MOTA1 = txtMoTa.Text;
            sp.LOAI1 = Convert.ToInt32(DropDownList1.SelectedValue);
            sp.TRANGTHAI1 = chkTrangThai.Checked;
            if (SanPham_BUS.CapNhatSanPham(sp))
            {
                LoadDanhSachSanPham();
                XoaForm();
            }
            else
            {
                Response.Write("<script>alert('Cập nhật sản phẩm thất bại');</script>");
            }

        }

        protected void btnHuyBo_Click(object sender, EventArgs e)
        {
            XoaForm();
        }
        public void XoaForm()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtMoTa.Text = "";
            txtMaSanPham.Enabled = true;
        }
    }
}