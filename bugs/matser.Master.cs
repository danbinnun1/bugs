using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class matser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Member user = (Member)Session["user"];
            if (user == null) return;
            var type = user.rank;
            var des = $"Ahoy! {user.username}!";
            switch (type)//display the right nave bar
            {
                case Member.regular:
                    //sh
                    normal.Visible = true;
                    UserString.Text = des;
                    break;
                case Member.moderator:
                    //system
                    moderator.Visible = true;
                    moderatorString.Text = des;
                    break;
            }
            UnConected.Visible = false;
        }

        protected void LogOut1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("welcome.aspx");
        }

        protected void LogoB_OnClick(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("welcome.aspx");
        }
    }
}