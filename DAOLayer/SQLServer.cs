using System;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAOLayer
{
    public class SQLServer : ISQLServer
    {
        public bool CreateUserLogin(string username, string password)
        {
           string Connectionstring= ConfigurationSettings.AppSettings.Get("Connectionstring");
            SqlConnection sqlConnection = new SqlConnection(Connectionstring);
            bool sucuss;
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO [dbo].[TblUserDetail] values (@UserName ,@Password)", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add("@UserName", DbType.String);
                sqlCommand.Parameters["@UserName"].Value = username;

                sqlCommand.Parameters.Add("@Password", DbType.String);
                sqlCommand.Parameters["@Password"].Value = password;

                sucuss = Convert.ToBoolean(sqlCommand.ExecuteNonQuery());
            }
            catch (SqlException exsql)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return sucuss;
        }

        public string UserLogin(string username, string password)
        {
            string Connectionstring = ConfigurationSettings.AppSettings.Get("Connectionstring");
            SqlConnection sqlConnection = new SqlConnection(Connectionstring);
           // SqlConnection sqlConnection = new SqlConnection(@"Data Source=MUM02L5446\SQLEXPRESS;Initial Catalog=mylocalDB;Persist Security Info=True;User ID=sa;Password=Password123");
            string loggedInusername = string.Empty;
            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("select * from [dbo].[TblUserDetail] where UserName=@FirstName and Password=@Password ", sqlConnection);
                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Parameters.Add("@FirstName", DbType.String);
                sqlCommand.Parameters["@FirstName"].Value = username;

                sqlCommand.Parameters.Add("@Password", DbType.String);
                sqlCommand.Parameters["@Password"].Value = password;

                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.Read() && dr.HasRows)
                {
                    loggedInusername = Convert.ToString(dr["UserName"]);
                }
            }
            catch (SqlException exsql)
            {
                loggedInusername = exsql.Message;
                throw;
            }
            catch (Exception ex)
            {
                loggedInusername = ex.Message;
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return loggedInusername;
        }
    }
}
