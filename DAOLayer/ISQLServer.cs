using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLayer
{
    public interface ISQLServer
    {
        string UserLogin(string username, string password);

        bool CreateUserLogin(string username, string password);
    }
}
