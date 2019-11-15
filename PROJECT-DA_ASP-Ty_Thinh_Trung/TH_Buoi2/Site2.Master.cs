using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TH_Buoi2
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["TENTK1"];
            if(cookie !=null)
            {
                lblLoiChao.Text = "Xin Chào "+ cookie.Value;
            }else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("TENTK1");
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
            Response.Redirect("login.aspx");
        }
    }
}