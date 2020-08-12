using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoshopping
{
    public class Product
    {
        public string name;
        public int price;
        public Product(string nm, int prc)
        {
            name = nm;
            price = prc;
        }
    }


    public partial class _2Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]!=null)
            {
                username.Text = Session["username"].ToString();
                string intrest = RadioButtonList1.SelectedItem.Text;

                if (string.Compare(intrest, "Electronics") == 0)
                {
                    int i;
                    for(i=0;i<4;i++)
                    {
                        items.Items.FindByValue(i.ToString()).Enabled = true;
                    }
                    for (i = 4; i < 8; i++)
                    {
                        items.Items.FindByValue(i.ToString()).Enabled = false;
                    }
                }
                else
                {
                    int i;
                    for (i = 0; i < 4; i++)
                    {
                        items.Items.FindByValue(i.ToString()).Enabled = false;
                    }
                    for (i = 4; i < 8; i++)
                    {
                        items.Items.FindByValue(i.ToString()).Enabled = true;
                    }
                }
            }
            else
            {
                Response.Redirect("2Login.aspx");
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Items_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] prds = { "SamsungA51", "Chromebook", "iphoneX", "sandisk32gb3.0", "Ikagai", "ShivaTrilogy", "RichDadPoorDad", "Fake" };
            Product[] p1 = new Product[12];

            p1[0] = new Product("SamsungA51", 25000);
            p1[1] = new Product("Chromebook", 40000);
            p1[2] = new Product("iphoneX", 70000);
            p1[3] = new Product("sandisk32gb3.0", 599);
            p1[4] = new Product("Ikagai", 789);
            p1[5] = new Product("ShivaTrilogy", 699);
            p1[6] = new Product("RichDadPoorDad", 549);
            p1[7] = new Product("Fake", 499);


            int i;
            string intrest = RadioButtonList1.SelectedItem.Text;
            if (string.Compare(intrest, "Electronics") == 0)
            {
                for (i = 0; i < 4; i++)
                {
                    if (items.Items.FindByValue(i.ToString()).Selected)
                    {
                        Session[prds[i]] = p1[i];
                    }
                    else
                    {
                        Session[prds[i]] = null;
                    }
                }
                for (i = 4; i < 8; i++)
                {
                    Session[prds[i]] = null;
                }
            }
            else
            {
                for (i = 0; i < 4; i++)
                {
                    Session[prds[i]] = null;
                }
                for (i = 4; i < 8; i++)
                {
                    if (items.Items.FindByValue(i.ToString()).Selected)
                    {
                        Session[prds[i]] = p1[i];
                    }
                    else
                    {
                        Session[prds[i]] = null;
                    }
                }
            }
        }

        protected void Place_order_Click(object sender, EventArgs e)
        {   
            Response.Redirect("2order.aspx");
        }
    }
}