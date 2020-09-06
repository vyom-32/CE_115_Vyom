using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace Task2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string u, p, uget, pget;
            u = TextBox1.Text;
            p = TextBox2.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "select * from Users";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    int a = 0;
                    while (rdr.Read())
                    {
                        uget = rdr["userid"].ToString();
                        pget = rdr["password"].ToString();

                        if (u == uget && p == pget)
                        {
                            Session["uname"] = u;
                            Label1.Text = "yes";
                            a = 1;
                            Response.Redirect("product.aspx");
                            break;

                        }

                    }
                    if (a == 0)
                    {
                        Label1.Text = "Invalid username or password!!";
                    }
                }
            }
            catch (Exception err)
            {
                Label1.Text = "Error occured !!!";
                Label1.Text += err.Message;
            }
        }
    }
}