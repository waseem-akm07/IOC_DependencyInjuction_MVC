using System.Collections.Generic;
using System.Web.Http;
using System.Web.Routing;
using BusinessLayer.cs;
using IOC_DependencyInjuction.Models;

namespace IOC_DependencyInjuction.Controllers
{
    public class employeeController : ApiController
    {
        private readonly IBusinessLayer _iBusinessLayer;
               
        readonly IBusinessLayer businessLayer = new BusinessAccessLayer();

        public employeeController()
        {
            _iBusinessLayer = businessLayer;
        }

        // GET: api/employee
        [HttpGet]
        [Route("api/employee/getemployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            var data = _iBusinessLayer.GetAllEmployees();
            return data;
        }

        // GET: api/employee/5
        [HttpGet]
        [Route("api/employee/getemployee/{id}")]
        public Employee GetEmployee(int id)
        {
            var data = _iBusinessLayer.GetEmployee(id);
            return data;
        }

        // POST: api/employee
        [HttpPost]
        [Route("api/employee/postemployee")]
        public IHttpActionResult PostEmployee(Employee model)
        {
            _iBusinessLayer.CreateEmployee(model);
            string msg = "Data is Added Successfuly";           
            return Ok(msg);
        }

        // PUT: api/employee/5
        [HttpPut]
        [Route("api/employee/putemployee/{id}")]
        public IHttpActionResult PutEmployee(int id, Employee model)
        {
            _iBusinessLayer.UpdateEmployee(id, model);
            string msg = "Data is Updated Successfully";
            return Ok(msg);
        }

        // DELETE: api/employee/5
        [HttpDelete]
        [Route("api/employee/delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            _iBusinessLayer.DeleteEmployee(id);
            string msg = "Employee deleted successfully";
            return Ok(msg);
        }
    }
}
