using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class First
    {
        class Car
        {
            public string CarName;
            public string Type;
            public string Colour;
            public int Manufaturing;

            static void Main(string[] args)
            {
                Car c = new Car();
                c.CarName = "Creta";
                c.Type = "Petrol";
                c.CarName = "White";
                c.Manufaturing = 2020;
                Console.WriteLine(c);

                Console.WriteLine(c.CarName);
                Console.WriteLine(c.Type);
                Console.WriteLine(c.Colour);
                Console.WriteLine(c.Manufaturing);
            }
        }
    }
}
