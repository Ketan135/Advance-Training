using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayHomework
{
    internal class Cust
    {
        private string? nm;
        private int per;

        public Cust(string? nm, int per)
        {
            this.nm = nm;
            this.per = per;
        }
        public override string ToString()
        {
            return $"Name:{nm} Percent:{per}";
        }

        static void Main(string[] args)
        {
            Cust[] arr = new Cust[5];
            string nm;
            int per;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Name,Percentage of Student");
                nm = Console.ReadLine();
                per = int.Parse(Console.ReadLine());
                arr[i] = new Cust(nm, per);
            }
            for (int i = 0; i < arr.Length; i++)
            {

            }
        }
    }
}
