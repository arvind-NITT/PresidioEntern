using Day7ClassModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7BLLibrary
{
    internal interface IEmployeeService
    {
        int AddEmployee(Employee employee);
        Employee GetEmployeeById(int id);

        List<Employee> GetAllEmployees();
        List<Employee> GetEmployeesByEmployeeType(string type);
        List<Employee> GetEmployeesByEmployeeRole(string role);
        Department GetDepartmentByEmpId(int id);

        Employee UpdateEmpName(string EmployeeOldName, string EmployeeNewName);
        string GetEmployeeName(int id);
        string GetEmployeeRole(string Name);
        Employee DeleteEmployeeById(int id);


    }
}
