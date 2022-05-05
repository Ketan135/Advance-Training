using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public class Emp4
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }
    }
    internal class Emp2
    {
        static void Main(string[] args)
        {
            List<Emp4> list = new List<Emp4>()
            {
                new Emp4{Id =1,Name="A",City="Pune",Salary=30000,Dept="Developer"},
                new Emp4{Id =1,Name="B",City="Mumbai",Salary=40000,Dept="Developer"},
                new Emp4{Id =1,Name="C",City="Pune",Salary=15000,Dept="Developer"},
                new Emp4{Id =1,Name="D",City="Solapur",Salary=20000,Dept="Developer"},
                new Emp4{Id =1,Name="E",City="Mumbai",Salary=30000,Dept="Developer"},
                new Emp4{Id =1,Name="F",City="Goa",Salary=50000,Dept="Developer"},
                new Emp4{Id =1,Name="G",City="Pune",Salary=25000,Dept="Developer"},
                new Emp4{Id =1,Name="H",City="Pune",Salary=35000,Dept="Developer"},
                new Emp4{Id =1,Name="I",City="Pune",Salary=37000,Dept="Developer"},
                new Emp4{Id =1,Name="J",City="Pune",Salary=32000,Dept="Developer"},
            };
            
            var result2 = from e in list
                              // where e.Salary>45000
                              //orderby e.City
                              //where e.City.Contains("Mumbai")
                              // where e.Dept=="Developer"
                              //orderby e.Salary descending
                              //where e.Name.StartsWith('A')||e.Name.StartsWith('K')
                         where e.City.Contains("Pune")&&e.Salary<35000
           
                        select e;
            foreach(Emp4 e in result2)
            {
                Console.WriteLine($"{e.Name}{e.Dept}{e.City}{e.Salary}");
            }
        }
    }
}
