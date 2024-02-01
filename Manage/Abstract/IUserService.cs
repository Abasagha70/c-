using LoginRegister.entity;
using LoginRegister.Helper.ReturnResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegister.Manage.Abstract
{
    public interface IUserService
    {
        ReturnResult<User>Login (string username, string password, string usernamee);
        ReturnResult<User> Register (User user);

    }
}
