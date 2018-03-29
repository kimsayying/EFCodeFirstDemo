using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3;

namespace WebApplication3
{
    public class EmployeeRespository
    {
      
        public List<Department> GetDepartments()
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
           return dbContext.Department.Include("Employees").ToList(); //webform eval,department same employees
        }
     
    }
}