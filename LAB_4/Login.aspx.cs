using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_b_click(object sender, EventArgs e)
        {
            string uname=username.Text, pass=Password.Text;
            if(string.Compare(uname,pass)==0 && string.Compare(uname,"admin")==0)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Message.Text = "Incorrect credentials";
            }
        }
    }
}