using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task4
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext dbctx = new SampleDataContext();
            GridView1.DataSource = from student in dbctx.Students select student;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ok.Visible = true;
            int id = Int32.Parse(TextBox6.Text);
            using (SampleDataContext dbctx = new SampleDataContext())
            {
                Student obj = dbctx.Students.SingleOrDefault(x => x.sid == id);
                TextBox1.Text = obj.name;
                TextBox2.Text = obj.sem;
                TextBox3.Text = obj.cpi;
                TextBox4.Text = obj.contactno;
                TextBox5.Text = obj.emailid;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TextBox6.Text);
            using (SampleDataContext dbctx = new SampleDataContext())
            {
                Student obj = dbctx.Students.SingleOrDefault(x => x.sid == id);

                obj.name = TextBox1.Text;
                obj.sem = TextBox2.Text;
                obj.cpi = TextBox3.Text;
                obj.contactno = TextBox4.Text;
                obj.emailid = TextBox5.Text;
                dbctx.SubmitChanges();
                Response.Redirect("update.aspx");
            }
        }
    }
}