using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.BAL.Interface
{
    public interface IEmployeeManager
    {
        List<EmployeeModel> GetEmployees();
        EmployeeModel GetEmployeeById(int id);
        void AddEmployee(EmployeeModel model);
        void UpdateEmployee(int id, EmployeeModel model);
        void DeleteEmployee(int id);
        List<EmployeeModel> GetAllManagers();
    }
}
