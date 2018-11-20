using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EFLApp.Data;
using EFLApp.Entity;
namespace EFLApp.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [ActionName("SIMPLY")]
        public string SIMPLY()
        {
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();
            using (var ctx = new EmployeeDBContext())
            {
                var employee = new Employee() { FirstName = "kumar", LastName="shubhendu", Gender="Male",  Salary=23456};
                ctx.Employees.Add(employee);
                ctx.SaveChanges();
            }
                return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
