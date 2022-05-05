using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class Pen
    {
        string Brand;
        string Type;
        String Colour;
        int Price;

        public Pen()
        {
            Console.WriteLine("Inside default");
        }
        public void setBrand(string b1)
        {
            Brand = b1;
        }
        public string getBrand()
        {
            return Brand;
        }
        public void setType(String t1)
        {
            Type = t1;
        }
        public String getType()
        {
            return Type;
        }
        public void setColour(String c1)
        {
            Colour = c1;
        }
        public String getColour()
        {
            return Colour;
        }
        public void setPrice(int p1)
        {
            Price = p1;
        }
        public int getPrice()
        {
            return Price;
        }


    }
    class d1
    {
        static void Main(string[] args)
        {
            Pen d1 = new Pen();
            Console.WriteLine("Enter Brand");
            d1.setBrand(Console.ReadLine());
            Console.WriteLine("Enter Type");
            d1.setType(Console.ReadLine());
            Console.WriteLine("Enter Colour");
            d1.setColour(Console.ReadLine());
            Console.WriteLine("Enter Price");
            d1.setPrice(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Brand is " + d1.getBrand());
            Console.WriteLine("Type is " + d1.getType());
            Console.WriteLine("Colour is " + d1.getColour());
            Console.WriteLine("Price is " + d1.getPrice());
        }
    }
}
