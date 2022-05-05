using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Harshad
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int r = 0, sum = 0;
            int temp = num;


            while (num > 0)
            {
                r = num % 10;
                sum = sum + r;
                num = num / 10;
            }

            if (temp % sum == 0)
            {
                Console.WriteLine("This Is Harshad Number");
            }
            else
            {
                Console.WriteLine("This Is NOT Harshad Number");
            }
        }
    }
}

