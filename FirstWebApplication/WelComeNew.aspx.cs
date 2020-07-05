using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class WelComeNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Session["UserName"])))
            {
                Response.Write("WelComeNew !"+ Convert.ToString(Session["UserName"]));
            }
            else
            {
                Session["UserName"] = "";
                Response.Write("Login failed");
                Response.Redirect("Login.aspx");
            }
        }
    }
}