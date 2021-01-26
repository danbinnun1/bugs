using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class wallofshame : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Report> pendingReports = Report.AcceptedReports();
                Session["reports"] = pendingReports;
                reports.DataSource = pendingReports;
                reports.DataBind();
            }
        }

        protected void reports_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "readmore")
            {
                int id = e.Item.ItemIndex;
                Report report = ((List<Report>)Session["reports"])[id];
                Session["report"] = report;
                Response.Redirect("reportforum.aspx");
            }
        }

        
    }
}