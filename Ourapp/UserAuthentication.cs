using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ourapp
{
    public class UserAuthentication
    {
        public static string UserLogin(string username, string password)
        {
            
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return "Please Provide username and password first";

            }
            if((username == "sam1256") || (password == "sam@1256@1256")) {
                return "Login Success";
            }
            else
            {
                return "Login Fail";
            }

        }
 

    }
}
