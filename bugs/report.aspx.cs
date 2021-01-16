using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL;

namespace bugs
{
    public partial class report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit(object sender, EventArgs e)
        {
            string extention = image.FileName.Substring(image.FileName.IndexOf("."));
            Report r = new Report(0, description.Text, ((Member)Session["user"]).id, DateTime.Now.ToString(), Status.pending, "","");
            r.Insert();
            image.SaveAs("C:\\Users\\danbi\\Source\\Repos\\bugs\\bugs\\reports\\"+r.ID+extention);
            r.updateImage("C:\\Users\\danbi\\Source\\Repos\\bugs\\bugs\\reports\\" + r.ID + extention);
        }
    }
}