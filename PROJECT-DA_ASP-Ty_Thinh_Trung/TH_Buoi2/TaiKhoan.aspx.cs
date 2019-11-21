using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;
using System.IO;
namespace TH_Buoi2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadDanhSachTaiKhoan();
                btnSua.Enabled = false;
                btnSua.Visible = false;
                btnHuyBo.Visible = false;
            }
        }
        //lấy danh sách từ sql server lên host
        public void LoadDanhSachTaiKhoan()
        {
            grvAccount.DataSource = TaiKhoan_BUS.LayDSTaiKhoan();
            grvAccount.DataBind();
        }
       

        protected void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan_DTO tk = new TaiKhoan_DTO();
            
                tk.TENTK1 = txtTenTaiKhoan.Text;
                tk.MATKHAU1 = txtMatKhau.Text;
                tk.EMAIL1 = txtEmail.Text;
                tk.SDT1 = txtSDT.Text;
                tk.DIACHI1 = txtDiaChi.Text;
                tk.HOTEN1 = txtHoTen.Text;
                tk.LAADMIN1 = chkLaAdmin.Checked;
                tk.ANHDAIDIEN1 = txtAnhDaiDien.Text;
                
                tk.TRANGTHAI1 = chkTrangThai.Checked;
                if (TaiKhoan_BUS.ThemTaiKhoan(tk))
                {
                    LoadDanhSachTaiKhoan();
                }
                else
                {
                    Response.Write("<script>alert('Thêm tài khoản thất bại');</script>");
                }
            }
            catch (Exception error)
            {
                Response.Write("<script>alert('Thêm tài khoản thất bại');</script>");
            }


        }

        protected void grvAccount_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ChonTK")
            {
                btnThem.Visible = false;
                btnSua.Visible = true;
                btnSua.Enabled = true;
                btnHuyBo.Visible = true;
                string TENTK = e.CommandArgument.ToString();
                TaiKhoan_DTO tk = TaiKhoan_BUS.LayThongTinTaiKhoan(TENTK);
                if (tk != null)
                {
                    txtTenTaiKhoan.Text = tk.TENTK1;
                    txtTenTaiKhoan.Enabled = false;
                    txtMatKhau.Text = tk.MATKHAU1;
                    txtEmail.Text = tk.EMAIL1;
                    txtSDT.Text = tk.SDT1;
                    txtDiaChi.Text = tk.DIACHI1;
                    txtHoTen.Text = tk.HOTEN1;
                    chkLaAdmin.Checked = tk.LAADMIN1;
                    txtAnhDaiDien.Text = tk.ANHDAIDIEN1;
                    chkTrangThai.Checked = tk.TRANGTHAI1;
                }
            }
            if (e.CommandName == "XoaTK")
            {
                string TENTK = e.CommandArgument.ToString();
                if (TaiKhoan_BUS.XoaTaiKhoan(TENTK))
                {
                    LoadDanhSachTaiKhoan();
                    XoaFrom();
                }
                else
                {
                    Response.Write("<script>alert('Xoá tài khoản thất bại');</script>");
                }
            }
        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            txtTenTaiKhoan.Enabled = true;
            TaiKhoan_DTO tk = TaiKhoan_BUS.LayThongTinTaiKhoan(txtTenTaiKhoan.Text);
            tk.TENTK1 = txtTenTaiKhoan.Text;
            tk.MATKHAU1 = txtMatKhau.Text;
            tk.EMAIL1 = txtEmail.Text;
            tk.SDT1 = txtSDT.Text;
            tk.DIACHI1 = txtDiaChi.Text;
            tk.HOTEN1 = txtHoTen.Text;
            tk.LAADMIN1 = chkLaAdmin.Checked;
            tk.ANHDAIDIEN1 = txtAnhDaiDien.Text;
            tk.TRANGTHAI1 = chkTrangThai.Checked;
            if (TaiKhoan_BUS.CapNhatTaiKhoan(tk))
            {
                LoadDanhSachTaiKhoan();
                XoaFrom();
                btnHuyBo.Visible = false;
                btnSua.Visible = false;
                btnThem.Enabled = true;
            }
            else
            {
                Response.Write("<script>alert('Sửa tài khoản thất bại');</script>");
            }
        }

        protected void btnHuyBo_Click(object sender, EventArgs e)
        {      
               
                 btnThem.Visible = true;
                 XoaFrom();
                btnHuyBo.Visible = false;
                btnSua.Visible = false;
                txtTenTaiKhoan.Enabled = true;
        }
        public void XoaFrom()
        {
            txtHoTen.Text = "";
            txtMatKhau.Text = "";
            txtTenTaiKhoan.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtAnhDaiDien.Text = "";
            chkLaAdmin.Checked = false;
            chkTrangThai.Checked = false;
        }
    }
}