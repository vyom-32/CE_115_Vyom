using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task2
{
    public partial class second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] names = { "vyom", "jay", "kishan", "karan", "raj", "ridham", "vedant", "harsh", "kevin", "yash" };
            string txt = "";
            foreach (var i in names)
            {
                txt += i.ToString() + " ";
            }
            Label1.Text = txt;

            txt = "";
            foreach (var i in names.Where((s) => s[0] == 'k'))
            {
                txt += i.ToString() + " ";
            }
            Label2.Text = txt;

            txt = "";
            foreach (var i in names.Where((s) => s.Length < 4))
            {
                txt += i.ToString() + " ";
            }
            Label3.Text = txt;

            txt = "";
            foreach (var i in names.Where((s) => s.Length == 3))
            {
                txt += i.ToString() + " ";
            }
            Label4.Text = txt;


            IEnumerable<string> query = from name in names
                                        orderby name
                                        select name;
            txt = "";
            foreach (var i in query)
            {
                txt += i.ToString() + " ";
            }
            Label5.Text = txt;
        }
    }
}