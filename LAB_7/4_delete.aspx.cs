using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task4
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext dbctx = new SampleDataContext();
            GridView1.DataSource = from student in dbctx.Students select student;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TextBox1.Text);
            using (SampleDataContext dbctx = new SampleDataContext())
            {
                Student obj = dbctx.Students.SingleOrDefault(x => x.sid == id);
                dbctx.Students.DeleteOnSubmit(obj);
                dbctx.SubmitChanges();
                Response.Redirect("delete.aspx");
            }
        }
    }
}