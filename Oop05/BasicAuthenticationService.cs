using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, (string Password, string Role)> users = new Dictionary<string, (string, string)>
    {
        { "admin", ("1234", "Admin") },
        { "user1", ("abcd", "User") },
        { "manager", ("pass", "Manager") }
    };

        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username) && users[username].Password == password)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (users.ContainsKey(username) && users[username].Role == role)
            {
                return true;
            }
            return false;
        }
    }
}
