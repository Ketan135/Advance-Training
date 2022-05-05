using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public class S1
    {
        public int Roll_No { get; set; }
        public string Name { get; set; }
        public float Percentage { get; set; }
        public string Branch { get; set; }

    }
    internal class Student1
    {
        static void Main(string[] args)
        {
            List<S1> students = new List<S1>()
            {
                new S1 { Roll_No=1, Name="Anil",Percentage=90, Branch="Computer Engineering"},
                new S1 { Roll_No = 2, Name = "Rohit", Percentage = 95, Branch = "Mechanical Engineering" },
                new S1 { Roll_No = 3, Name = "Rahul", Percentage = 94, Branch = "E&TC Engineering" },
            };
            var result=from e in students
                       where e.Percentage>90
                       select e;
            foreach(S1 studens in result)
            {
                Console.WriteLine($"{studens.Percentage}");
            }
            var result1 = from e in students
                         where e.Branch.Contains("Computer Engineering")
                         select e;
            foreach (S1 studens in result)
            {
                Console.WriteLine($"{studens.Branch}");
            }
            var result2 = from e in students
                         where e.Roll_No == 1
                         select e;
            foreach (S1 studens in result)
            {
                Console.WriteLine($"{studens.Roll_No}");
            }
        }
    }
}
