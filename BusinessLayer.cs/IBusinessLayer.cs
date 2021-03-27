using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.cs
{
    public interface IBusinessLayer
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(int id, Employee employee);
        Employee DeleteEmployee(int id);
    }
}
