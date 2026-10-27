using System;
using System.Web.UI;

namespace aasiiments
{
    public partial class aasigement2_que2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblToday.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblSelected.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        }
    }
}