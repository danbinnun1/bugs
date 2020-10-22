using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (!IsPostBack && Session["user"] != null)
                Response.Redirect("welcome.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Validate();
            if (IsValid)
            {
                var userName = username.Text;
                var pass = password.Text;

                var user = Member.AuthUser(userName, pass);
                if (user == null)
                {
                    errorBox.Text = "Login did not work";
                }
                else
                {
                    Session["user"] = user;
                    //if (user.IsDeveloper) Session["dev"] = new Developer(user.DeveloperId);
                    //if (user.IsAdmin) Session["admin"] = true;
                    //Response.Redirect("Profile.aspx?id=" + user.Id);
                    Response.Redirect("welcome.aspx");
                }
            }
        }
    }
}
