using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class Stock1
    {
        string shareName;
        float openPrice;
        float closePrice;
        float price;
        public string Share
        {
            get { return shareName; }
            set { shareName = value; }
        }
        public float Open
        {
            get { return openPrice; }
            set { openPrice = value; }
        }
        public float Close
        {
            get { return closePrice; }
            set { closePrice = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }

        }


    }
    class z1
    {
        static void Main(string[] args)
        {
            Stock1 j1 = new Stock1();

            j1.Share = "Jio";
            j1.Open = 25165;
            j1.Close = 25265;
            j1.Price = 150;

            Console.WriteLine("Country Name: " + j1.Share);
            Console.WriteLine("Number of States: " + j1.Open);
            Console.WriteLine("Number Of Languages " + j1.Close);
            Console.WriteLine("Capital is " + j1.Price);
        }
    }
}