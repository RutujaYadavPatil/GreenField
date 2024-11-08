using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    public interface IAuthService
    {
        bool Login(string username, string password);
        bool Register(string username, string password);
        bool ForgotPassWord(string username);
        bool ResetPassWord(string username, string oldpassword , string newpassword);
    }
}
