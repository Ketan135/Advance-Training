using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Amicable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum1 = 0, sum2 = 0;

            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sum1 = sum1 + i;
                }

            }

            for (int i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum2 = sum2 + i;
                }

            }   



            if (sum1 == num2 && sum2 == num1)
            {
                Console.WriteLine($"{num1} and {num2} are Amicable Numbers");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are NOT Amicable Numbers");
            }
        }
    }
}
