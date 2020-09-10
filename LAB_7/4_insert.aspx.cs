using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task4
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext dbctx = new SampleDataContext();
            GridView1.DataSource = from student in dbctx.Students select student;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, sem, cpi, cn, mail;
            name = TextBox1.Text;
            sem = TextBox2.Text;
            cpi = TextBox3.Text;
            cn = TextBox4.Text;
            mail = TextBox5.Text;
            using (SampleDataContext dbctx = new SampleDataContext())
            {
                Student obj = new Student { name = name, sem = sem, cpi = cpi, contactno = cn, emailid = mail };
                dbctx.Students.InsertOnSubmit(obj);
                dbctx.SubmitChanges();
            }
            Response.Redirect("insert.aspx");
        }

    }
}