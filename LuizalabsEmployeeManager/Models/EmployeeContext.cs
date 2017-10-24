using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace employee.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() : base("EmployeeLocal"){ } //Define base name

        public DbSet<Employee> Employees { get; set; }


    }
}