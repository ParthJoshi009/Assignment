using Employeemanagement.DAL.Interface;
using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.BAL.Interface
{
    public interface ILoginManager
    {
        string login(LoginModel loginModel);
    }
}
