using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    internal class Emp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] arr1 = new int[] { 10, 20, 30, 40, 50 };

            string[] arr2 = { "Ajay", "Amol" };


            Product[] prodlist2 = new Product[]
           {
                 new Product{Id=4, Name="Keyboaard" }, // set
                 new Product{Id=5, Name="mouse"  },
                 new Product{Id=6, Name="RAM"  }
           };

            foreach (Product p in prodlist2) // curren -> Id =6
            {
                Console.WriteLine($"{p.Id} -> {p.Name}"); // get
            }

            foreach (Product p in prodlist2) // curren -> Id =6
            {
                Console.WriteLine($"{p.Id} -> {p.Name}"); // get
            }
        }
        
    public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            
        }

    }
}

