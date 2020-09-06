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
    public partial class Edit : System.Web.UI.Page
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            Table1.Visible = true;
            string id = TextBox1.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "Select * from student where id =" + id;
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        oname.Text = rdr["name"].ToString();
                        osem.Text = rdr["sem"].ToString();
                        omono.Text = rdr["mobileno"].ToString();
                        oemail.Text = rdr["email"].ToString();
                    }



                }
            }
            catch (Exception err)
            {
                Label1.Text = "Error occured !!!";
                Label1.Text += err.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            string id = TextBox1.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["ConTest"].ConnectionString;
            string name = oname.Text;
            string sem = osem.Text;
            int s = Int32.Parse(sem);
            string mn = omono.Text;
            string email = oemail.Text;
            Table1.Visible = false;
            try
            {
                string command = "UPDATE student SET name =@0,sem = @1,Mob_No=@2,email_id=@3 WHERE id =" + id;
                con.Open();
                using (var cmd = new SqlCommand(command, con))
                {
                    cmd.Parameters.AddWithValue("@0", name);
                    cmd.Parameters.AddWithValue("@1", s);
                    cmd.Parameters.AddWithValue("@2", mn);
                    cmd.Parameters.AddWithValue("@3", email);

                    cmd.ExecuteNonQuery();
                    Response.Redirect("edit.aspx");
                }
                con.Close();
            }
            catch (Exception err)
            {
                Label1.Text = "Error occured !!!";
                Label1.Text += err.Message;
            }
        }
    }
}