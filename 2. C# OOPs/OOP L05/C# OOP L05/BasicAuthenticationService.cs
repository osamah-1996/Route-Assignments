using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__OOP_L05
{
     
         public class BasicAuthenticationService : IAuthenticationService
        {
             private readonly Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "password123" },
            { "user", "pass123" }
        };

             private readonly Dictionary<string, string> roles = new Dictionary<string, string>
        {
            { "admin", "Administrator" },
            { "user", "User" }
        };

             public bool AuthenticateUser(string username, string password)
            {
                return users.ContainsKey(username) && users[username] == password;
            }

            public bool AuthorizeUser(string username, string role)
            {
                return roles.ContainsKey(username) && roles[username] == role;
            }
       
    }

}
