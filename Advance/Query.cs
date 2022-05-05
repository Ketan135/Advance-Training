/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    class Query
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id = 1, Name ="Asus",Price =62500},
                new Product{Id = 2, Name ="HP",Price=50000},
                new Product{Id = 2, Name ="Acer",Price=40000},
                new Product{Id = 2, Name ="Dell",Price=60000},
                new Product{Id = 2, Name ="Lenovo",Price=30000},
                new Product{Id = 2, Name ="HP",Price=32000},
            };
            foreach (Product p in products)
            {
                Console.WriteLine($"{p.Name}{p.Price}");

                var result1 = from p in products
                              where p.Name.Contains("Dell")
                            select p;
                foreach (Product p in result1)
                {
                    Console.WriteLine($"{p.Name}{p.Price}");
                }
                            
            }
        }
    }
}
*/