using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            string st = State.SelectedItem.Text;
            if (string.Compare(st, "Gujarat") == 0)
            {
                City.Items.FindByText("Mumbai").Enabled = false;
                City.Items.FindByText("Pune").Enabled = false;
                City.Items.FindByText("Ahmedabad").Enabled = true;
                City.Items.FindByText("Vadodara").Enabled = true;
            }
            else
            {
                City.Items.FindByText("Ahmedabad").Enabled = false;
                City.Items.FindByText("Vadodara").Enabled = false;
                City.Items.FindByText("Mumbai").Enabled = true;
                City.Items.FindByText("Pune").Enabled = true;
            }
        }

        protected void State_Changed(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string gen = "";
            
            if (Male.Checked)
            {
                gen = Male.Text;
            }
            if (Female.Checked)
            {
                gen = Female.Text;
            }

            string hob = "";
            if (Swimming.Checked)
            {
                hob = "Swimming";
            }
            if (Volleyball.Checked)
            {
                hob = hob + " Volleyball";
            }
            if (Archery.Checked)
            {
                hob = hob + " Archery";
            }
            
            if (Page.IsValid)
            {
                Full_name_lable.Text = Full_name.Text;
                Age_label.Text = Age.Text;
                Gender_label.Text = gen;
                Mobile_no_label.Text = Mobile_no.Text;
                Hobbies_label.Text = hob;
                State_label.Text = State.Text;
                City_label.Text = City.Text;
                PAN_label.Text = PAN.Text;
                message.Visible = false;
            }
            else
            {
                message.Text = "validation failed";
            }
        }
        protected void PAN_validate(object source, ServerValidateEventArgs args)
        {
            string pan = PAN.Text;
            if (args.Value == "")
            {
                args.IsValid = false;

            }
            else
            {
                int len = pan.Length;

                if (len == 10 && (pan[0] == 'A' || pan[0] == 'B'))
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }
    }
}