using Employeemanagement.BAL.Interface;
using Employeemanagement.DAL.Interface;
using Employeemanagement.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employeemanagement.BAL
{
    public class EmployeeManager : IEmployeeManager
    {
        IEmployee employee;
        public EmployeeManager(IEmployee iemployee)
        {
            employee = iemployee;
        }
       public void AddEmployee(EmployeeModel model)
        {
             employee.AddEmployee(model);
        }

        public void DeleteEmployee(int id)
        {
            employee.DeleteEmployee(id);
        }

        public List<EmployeeModel> GetAllManagers()
        {
            return employee.GetAllManagers();
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return employee.GetEmployeeById(id);
        }

        public List<EmployeeModel> GetEmployees()
        {
            return employee.GetEmployees();
        }

        public void UpdateEmployee(int id, EmployeeModel model)
        {
            employee.UpdateEmployee(id, model);
        }
    }
}
