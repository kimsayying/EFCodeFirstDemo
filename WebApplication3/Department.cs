using System.Collections.Generic;

namespace WebApplication3
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Employee> Employees {get;set;}

    }
}