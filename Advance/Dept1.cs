using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public class Employee
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
    public class Department
    {
        public string DName { get; set; }

    public List<Employee> Employees = new List<Employee>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Department> department = new List<Department>()
            {
            new Department { DName = "Developer", Employees ={
                    new Employee { Name = "ABC", City = "Pune" },
                    new Employee { Name = "XYZ", City = "Pune" }
                }},

            };


            foreach (Department d in department)
            {
                Console.WriteLine(d.DName);
                foreach (Employee e in d.Employees)
                {
                    Console.WriteLine($"\t{e.Name}{e.City}");
                }
            }
        }
    }
}