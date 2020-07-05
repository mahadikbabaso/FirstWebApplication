using DAOLayer;

namespace BuisnessLayer
{
    public class UserDetails
    {
        ISQLServer _sqlserver;
        public UserDetails(ISQLServer sqlserver)
        {
            _sqlserver = sqlserver;
        }
        public string UserLogin(string username, string password)
        {

            return _sqlserver.UserLogin(username, password);
        }

        public bool CreateUserLogin(string username, string password)
        {

            return _sqlserver.CreateUserLogin(username, password);
        }
    }
}
