using Employeemanagement.BAL.Interface;
using Employeemanagement.DAL;
using Employeemanagement.DAL.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.BAL
{
    public static class UnityHelper
    {
        public static void Configure(ref IServiceCollection iserviceCollectoin)
        {
            iserviceCollectoin.AddScoped<IEmployee, Employee>();
            iserviceCollectoin.AddScoped<ILogin, Login>();
        }
    }
}
