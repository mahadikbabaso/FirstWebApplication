using BuisnessLayer;
using DAOLayer;
using System;
namespace FirstWebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                ISQLServer _sqlserver = new SQLServer();
                UserDetails sqlserver = new UserDetails(_sqlserver);
                string UserName = sqlserver.UserLogin(txtUserName.Text, txtPassword.Text);

                Session["UserName"] = UserName;

                Response.Redirect("WelComeNew.aspx");
            }
            else
            {
                Response.Write("Login failed");
                Response.Redirect("Login.aspx");
            }


        }
    }
}