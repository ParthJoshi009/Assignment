using Employeemanagement.BAL.Interface;
using Employeemanagement.DAL.Interface;
using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.BAL
{
    public class LoginManager : ILoginManager
    {
        ILogin _login;
        public LoginManager(ILogin ilogin)
        {
            _login = ilogin;
        }
        public string login(LoginModel loginModel)
        {
            return _login.login(loginModel);
        }
    }
}
