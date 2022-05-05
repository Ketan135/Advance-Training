using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class SpyNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int r = 0, sum = 0, prod = 1;
            int temp = num;


            while (num > 0)
            {
                r = num % 10;
                sum = sum + r;
                prod = prod * r;
                num = num / 10;
            }
            Console.WriteLine(sum);
            if (prod == sum)
            {
                Console.WriteLine("This is Spy Number");
            }
            else
            {
                Console.WriteLine("This is NOT a Spy Number");
            }
        }
    }
}

