using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace class_project
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        string Gender;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            label3.Text = "selected date is : " + Calendar1.SelectedDate.ToString("dd-MM-yy") + " and selected day is : " + Calendar1.SelectedDate.DayOfWeek.ToString();
        }

        protected void Unnamed1_CheckedChanged(object sender, EventArgs e)
        {

            Gender = "female";
        }

        protected void Unnamed2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            Label1.Text = "you have selected gender : " + Gender;
            //if (male.Checked)
            //{
            //    Label1.Text = "you have selected male";
            //}
            //else if (female.Checked)
            //{
            //    Label1.Text = "you have selected female";
            //}
            //else
            //{
            //    Label1.Text = "please select your gender";
            //}
        }

        protected void Unnamed1_CheckedChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            if(checkbox1.Checked)
            {
                total += 100;
            }
            if(checkbox2.Checked)
            {
                total += 200;
            }
            if(checkbox3.Checked)
            {
                total += 300;
            }
            label2.Text = "total amount is : " + total.ToString();
        }
    }
}