using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer.cs
{
    public class BusinessAccessLayer : IBusinessLayer
    {
        private MvcdbEntities db = new MvcdbEntities();

        public IEnumerable<Employee> GetAllEmployees()
        {
            try
            {
                return db.Employees.ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                var data = db.Employees.Find(id);
                return data;
            }
            catch
            {
                throw;
            }
        }

        public Employee CreateEmployee( Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return employee;
            }
            catch
            {
                throw;
            }
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            try
            {
                var emp = db.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
                emp.EmployeeName = employee.EmployeeName;
                emp.EmployeeAddress = employee.EmployeeAddress;
                emp.EmployeeSalary = employee.EmployeeSalary;

                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return employee;
            }
            catch
            {
                throw;
            }
        }

        public Employee DeleteEmployee(int id)
        {
            try
            {
                var data = db.Employees.Find(id);
                db.Employees.Remove(data);
                db.SaveChanges();
                return data;
            }
            catch
            {
                throw;
            }
        }
    }
}
