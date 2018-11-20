using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFLApp.Entity;

namespace EFLApp.Models
{
    public class EmployeeDBContext:DbContext
    {
        public EmployeeDBContext() : base() { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}