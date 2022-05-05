using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Bouncy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int next = num % 10;
            num = num / 10;

            bool isIncrease = true;
            bool isDecrease = true;

            while (num > 0)
            {
                int prev = num % 10;

                if (prev > next)
                {
                    isIncrease = false;
                }
                if (prev < next)
                {
                    isDecrease = false;
                }
                next = prev;
                num = num / 10;
            }

            if (isIncrease && isDecrease)
            {
                Console.WriteLine("All Digits Are Same");

            }
            else if (isIncrease)
            {
                Console.WriteLine("Number is Increasing");
            }
            else if (isDecrease)
            {
                Console.WriteLine("Number is Decreasing");
            }
            else
            {
                Console.WriteLine("Number is Bouncy");
            }
        }
    }
}