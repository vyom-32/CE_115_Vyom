using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace cookieDemo
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (Request.Cookies["User_Cookies"] == null)
            {
                Message.Text = "Cookies Expired";
            }
            else
            {
                Message.Text = "Cookies :<br>";
                foreach (string str in Request.Cookies["User_Cookies"].Values)
                {
                    Message.Text += str + "=" + Request.Cookies["User_Cookies"].Values[str] + "<br>";
                }
            }

        }
        
        protected void Delete_Click(object sender, EventArgs e)
        {
            Message.Text = "";
            Response.Cookies["User_Cookies"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("1Home.aspx");
        }
    }
}