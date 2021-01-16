using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class adminpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Report> pendingReports = Report.PendingReports();
                reports.DataSource = pendingReports;
                reports.DataBind();
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            object o = reports.FindControl("response");
            string response = (reports.FindControl("response") as TextBox).Text;
            bool accepted = ((reports.FindControl("status") as RadioButtonList).SelectedItem.Text == "accept");
            Report.update(accepted, response, int.Parse((reports.FindControl("id") as Label).Text));
        }
    }
}