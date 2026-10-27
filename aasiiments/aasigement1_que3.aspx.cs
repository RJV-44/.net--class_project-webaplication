using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aasiiments
{
    public partial class aasigement1_que3 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.FileName;
                string filePath = Server.MapPath("~/Image/") + fileName;

                FileUpload1.SaveAs(filePath);
                Label1.Text = "File uploaded successfully!";
            }
            else
            {
                Label1.Text = "Please select a file to upload.";
            }
        }
    }
}