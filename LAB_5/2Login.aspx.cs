using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoshopping
{
    public partial class _2Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Login_b_click(object sender, EventArgs e)
        {
            if(string.Compare(username.Text,"admin")==0 && string.Compare(Password.Text,"admin")==0)
            {
                Session["username"] = username.Text;
                Response.Redirect("2Home.aspx");
            }
            else
            {
                error.Text = "Incorrect Username/Password";
            }
            
        }
    }
}