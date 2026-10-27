using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class StudentRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
            }
        }

        protected void btnNext1_Click(object sender, EventArgs e)
        {
            // Move to View 2: Contact Info 
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnPrev2_Click(object sender, EventArgs e)
        {
            // Move back to View 1: Personal Info 
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnNext2_Click(object sender, EventArgs e)
        {
            // Populate View 3 Summary labels from View 1 and View 2 inputs             lblSummaryName.Text = txtName.Text;             lblSummaryGender.Text = rblGender.SelectedValue;             lblSummaryAddress.Text = txtAddress.Text;             lblSummaryDegree.Text = ddlDegree.SelectedValue;             lblSummaryEmail.Text = txtEmail.Text;             lblSummaryContact.Text = txtContact.Text;             lblSummaryCity.Text = txtCity.Text; 

            // Move to View 3: Summary 
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnPrev3_Click(object sender, EventArgs e)
        {
            // Move back to View 2: Contact Info 
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblStatusMessage.Text = "Student Details Submitted Successfully!"; btnSubmit.Enabled = false;
        }
    }
}
