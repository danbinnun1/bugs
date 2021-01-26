using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class reportforum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            report.Text = ((Report)Session["report"]).description;
            image.ImageUrl = ((Report)Session["report"]).image;
            if (!IsPostBack)
            {
                List<Comment> comments = Comment.GetByPost((Report)Session["report"]);
                Session["comments"] = comments;
                Comments.DataSource = comments;
                Comments.DataBind();
            }
        }

        protected void comments_ItemCommand(object source, DataListCommandEventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Comment com = new Comment((Member)Session["user"], comment.Text, (Report)Session["report"], DateTime.Now.ToString());
            com.Insert();
            Response.Redirect("reportforum.aspx");
        }
    }
}