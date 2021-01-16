using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Validate();
            if (!IsValid) return;
            var userName = username.Text;
            var pass = password.Text;
            var mail = email.Text;

            var user = Member.RegisterUser(Member.regular, userName, pass, mail);
            if (user == null)
            {
                errorBox.Text = "Register did not work";
            }
            else
            {

                image.SaveAs(Path.Combine("C:\\Users\\danbi\\source\\repos\\bugs\\bugs\\images\\", user.id+".png"));
                Session["user"] = user;
                //user.AddActivity("Created Account");
                //Response.Redirect("Profile.aspx?id=" + user.Id);
                Response.Redirect("welcome.aspx");
            }
        }
    }
}