using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class adminreports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Appeal> pending = Appeal.GetPending();
                Session["appeals"] = pending;
                reports.DataSource = pending;
                reports.DataBind();
            }
        }

        protected void reports_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "submit")
            {
                int id = e.Item.ItemIndex;
                string response = (e.Item.FindControl("response") as TextBox).Text;
                bool accepted = ((e.Item.FindControl("status") as RadioButtonList).SelectedItem.Text == "accept");
                Report.update(accepted, response, ((List<Appeal>)Session["appeals"])[id].AppealedReport.ID);
                ((List<Appeal>)Session["appeals"])[id].Update(accepted ? Status.approved : Status.denied);
                Response.Redirect("adminreports.aspx");
            }
        }
    }
}