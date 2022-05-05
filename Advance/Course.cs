using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public class Stud
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }
        public int Duration { get; set; }

    }
    internal class Course
    {
        static void Main(string[] args)
        {
            List<Stud> c = new List<Stud>()
            {
            new Stud { Id = 1, Name = "Computer Engineering", Fees = 300000, Duration = 3 },
            new Stud { Id = 2, Name = "E&TC", Fees = 280000, Duration = 3 },
            new Stud { Id = 3, Name = "Mechanical Engineering", Fees = 310000, Duration = 3 },
            new Stud { Id = 4, Name = "Automobile Engineering", Fees = 300000, Duration = 3 },
            };
            var result=from e in c
                       where e.Fees>300000
                       select e;
            foreach (Stud e in result)
            {
                Console.WriteLine($"{e.Fees}");
            }
            var result1 = from e in c
                         where e.Name.StartsWith('M')||e.Name.StartsWith('C')
                         select e;
            foreach (Stud e in result)
            {
                Console.WriteLine($"{e.Name}");
            }

            var result2 = from e in c
                         where e.Id == 1
                         select e;

            foreach (Stud e in result)
            {
                Console.WriteLine($"{e.Id}");
            }
        }
    }
}
