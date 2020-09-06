using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Task2
{

    public partial class Order : System.Web.UI.Page
    {
        public int count;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            try
            {
                using (con)
                {
                    string uid = Session["uname"].ToString();
                    string command = "Select * from Orders where userid='" + uid + "'";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridViewOrder.DataSource = rdr;
                    GridViewOrder.DataBind();
                    Label1.Text = "Welcome " + Session["uname"].ToString() + "!!!!";
                    count = GridViewOrder.Rows.Count;
                }
            }
            catch (Exception err)
            {
                Label1.Text = "Error occured !!!";
                Label1.Text += err.Message;
            }
            int[] arr = new int[count];
            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            try
            {
                using (con)
                {
                    string uid = Session["uname"].ToString();
                    string command = "Select * from Orders where userid='" + uid + "'";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    int i = 0;
                    while (rdr.Read())
                    {
                        string id = rdr["pid"].ToString();
                        arr[i] = Int32.Parse(id);
                        i += 1;

                    }
                }
            }
            catch (Exception err)
            {
                Label1.Text = "Error occured !!!";
                Label1.Text += err.Message;
            }
            int total = 0;
            string s = "";
            for (int i = 0; i < count; i++)
            {
                con = new SqlConnection();
                con.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                try
                {
                    using (con)
                    {
                        string pid = arr[i].ToString();
                        string command = "Select * from Product where pid='" + pid + "'";
                        SqlCommand cmd = new SqlCommand(command, con);
                        con.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            string name = rdr["pname"].ToString();
                            total += Int32.Parse(rdr["cost"].ToString());
                            s += name + " " + rdr["cost"].ToString() + ",";
                        }

                        Label2.Text = s;
                        Label3.Text = total.ToString();
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
}