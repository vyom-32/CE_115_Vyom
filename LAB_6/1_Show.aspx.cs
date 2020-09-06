using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace task1
{
    public partial class Show : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "Select * from student";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    GridViewStudent.DataSource = rdr;
                    GridViewStudent.DataBind();
                    Label1.Text = "Connection obtained successfully!!!";
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