using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFLApp.Entity;
namespace EFLApp.Data
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext():base("EFConnection")
            {
            }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}