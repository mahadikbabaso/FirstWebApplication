using BuisnessLayer;
using DAOLayer;
using System;

namespace FirstWebApplication
{
    public partial class MyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCreateLoginClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                ISQLServer _sqlserver = new SQLServer();
                UserDetails sqlserver = new UserDetails(_sqlserver);
                if (sqlserver.CreateUserLogin(txtUserName.Text, txtPassword.Text))
                {
                    Response.Redirect("Login.aspx");
                }

                else
                {
                    Response.Write("failed to create user plese try again");
                }
            }
            {
                Response.Write("plese enter username & password");
            }
        }
    }
}