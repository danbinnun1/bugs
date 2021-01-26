using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class myreports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Report> reports = ((Member)Session["user"]).GetReports();
                Session["myreports"] = reports;
                this.reports.DataSource = reports;
                this.reports.DataBind();
            }
        }

        protected void reports_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "submit")
            {
                int id = e.Item.ItemIndex;
                Report report = ((List<Report>)Session["myreports"])[id];

                string appealReason = (e.Item.FindControl("appealReason") as TextBox).Text;
                Appeal appeal = new Appeal(0, report, appealReason, Status.pending, "");
                appeal.Insert();
                
                Response.Redirect("myreports.aspx");
            }
        }
    }
}
