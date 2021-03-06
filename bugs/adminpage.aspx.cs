﻿using System;
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
                Session["reports"] = pendingReports;
                reports.DataSource = pendingReports;
                reports.DataBind();
            }
        }


        protected void reports_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "submit")
            {
                int id = e.Item.ItemIndex;
                Report report=((List<Report>)Session["reports"])[id];
                
                string response = (e.Item.FindControl("response") as TextBox).Text;
                bool accepted = ((e.Item.FindControl("status") as RadioButtonList).SelectedItem.Text == "accept");
                Report.update(accepted, response, ((List<Report>)Session["reports"])[id].ID);
                Response.Redirect("adminpage.aspx");
            }
        }
    }
}