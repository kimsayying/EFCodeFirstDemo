using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication3
{
    public class EmployeeDBContext :DbContext
    {
        //is going to interact with the database behind the scenes using dbContext class
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }

    }
}