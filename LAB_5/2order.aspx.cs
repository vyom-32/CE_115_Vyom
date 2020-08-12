using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace demoshopping
{
    public partial class _2order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] prds = { "SamsungA51", "Chromebook", "iphoneX", "sandisk32gb3.0", "Ikagai", "ShivaTrilogy", "RichDadPoorDad", "Fake" };
            int i, total = 0;
            for (i = 0; i < 8; i++)
            {
                if (Session[prds[i]] != null)
                {
                    Product p = (Product)Session[prds[i]];
                    Products.Text += p.name + " : " + p.price.ToString() + "<br/>";
                    total += p.price;
                }
            }
            Total_price.Text = "Total price : "+total.ToString();

        }

    }
}
