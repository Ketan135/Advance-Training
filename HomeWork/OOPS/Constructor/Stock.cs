using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class Stock
    {
        string ShareName;
        float OpenPrice;
        float ClosePrice;
        float Price;

        public Stock()
        {
            Console.WriteLine("Inside default");
        }
        public void setShareName(string s1)
        {
            ShareName = s1;
        }
        public string getShareName()
        {
            return ShareName;
        }
        public void setOpenPrice(float o1)
        {
            OpenPrice = o1;
        }
        public float getOpenPrice()
        {
            return OpenPrice;
        }
        public void setClosePrice(float p1)
        {
            ClosePrice = p1;
        }
        public float getClosePrice()
        {
            return ClosePrice;
        }
        public void setPrice(float d1)
        {
            Price = d1;
        }
        public float getPrice()
        {
            return Price;
        }


    }
    class k1
    {
        static void Main(string[] args)
        {
            Stock k1 = new Stock();
            Console.WriteLine("Enter Share Name");
            k1.setShareName(Console.ReadLine());
            Console.WriteLine("Enter Open Circuit");                               
            k1.setOpenPrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter Close Circuit");
            k1.setClosePrice(Convert.ToSingle(Console.ReadLine()));
            Console.WriteLine("Enter Price");
            k1.setPrice(Convert.ToSingle(Console.ReadLine()));

            Console.WriteLine("Share Name is " + k1.getShareName());
            Console.WriteLine("Open Circuit is " + k1.getOpenPrice());
            Console.WriteLine("Close Circuit is " + k1.getClosePrice());
            Console.WriteLine("Price is " + k1.getPrice());
        }
    }
}
