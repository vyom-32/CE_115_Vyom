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
    public class Data
    {
        public string name, price, pid;
        public Data(string id, string n, string p)
        {
            pid = id;
            name = n;
            price = p;
        }


    }

    public partial class Product : System.Web.UI.Page
    {
        public int count = 0;
        public Data[] obj;

        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "Select * from Product";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridViewProduct.DataSource = rdr;
                    GridViewProduct.DataBind();
                    Label1.Text = "Welcome " + Session["uname"].ToString() + "!!!!";
                    count = GridViewProduct.Rows.Count;
                }
            }
            catch (Exception err)
            {
                Label1.Text = "Error occured !!!";
                Label1.Text += err.Message;
            }


            con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "Select * from product";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();

                    SqlDataReader rdr = cmd.ExecuteReader();

                    obj = new Data[count];
                    int i = 0;
                    while (rdr.Read())
                    {
                        string p = rdr["pname"].ToString();
                        string id = rdr["pid"].ToString();
                        string cost = rdr["cost"].ToString();
                        obj[i] = new Data(id, p, cost);
                        i += 1;
                        ListItem Item = new ListItem();
                        Item.Text = p;
                        Item.Value = id;
                        ListBox1.Items.Add(Item);
                    }

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
            string item;
            for (int i = 0; i < count; i++)
            {
                if (ListBox1.Items.FindByText(obj[i].name).Selected)
                {
                    item = obj[i].pid;
                    string un = Session["uname"].ToString();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = WebConfigurationManager.ConnectionStrings["Test"].ConnectionString;
                    try
                    {
                        using (con)
                        {
                            string command = "insert into Orders (userid,pid) values ('" + un + "','" + Int32.Parse(item) + "')";
                            SqlCommand cmd = new SqlCommand(command, con);
                            con.Open();

                            SqlDataReader rdr = cmd.ExecuteReader();
                            
                        }

                    }
                    catch (Exception err)
                    {
                        Label1.Text = "Error occured !!!";
                        Label1.Text += err.Message;
                    }
                }
            }
            Response.Redirect("Order.aspx");
            
        }
    }
}