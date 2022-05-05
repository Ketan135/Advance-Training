using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class Pen1
    {
        string brand;
        string type;
        string colour;
        int price;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }

        }


    }
    class p1
    {
        static void Main(string[] args)
        {
            Pen1 j1 = new Pen1();

            j1.Brand = "Cello";
            j1.Type = "Gel";
            j1.Colour = "Blue";
            j1.Price = 20;

            Console.WriteLine("Country Name: " + j1.Brand);
            Console.WriteLine("Number of States: " + j1.Type);
            Console.WriteLine("Number Of Languages " + j1.Colour);
            Console.WriteLine("Capital is " + j1.Price);
        }
    }
}