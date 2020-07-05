using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApplication
{
    public partial class MyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string appseting = ConfigurationManager.AppSettings["name"];
            if (appseting.Equals("Test"))
            {
                Response.Write("Got it");
            }
        }

        protected void btnMyName_Click(object sender, EventArgs e)
        {
            //Label1.Text = "My name is : " + txtFirstName.Text + " " + txtLastName.Text;
            Response.Redirect("Login.aspx");
        }
    }
}