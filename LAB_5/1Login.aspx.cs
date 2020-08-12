using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookieDemo
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        HttpCookie myCookie;
        protected void Login_b_click(object sender, EventArgs e)
        {
            myCookie = new HttpCookie("User_Cookies");
            myCookie.Values["name"] = username.Text;
            Response.Cookies.Add(myCookie);
            Response.Redirect("1Home.aspx");
        }
    }
}