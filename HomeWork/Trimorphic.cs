using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            int cube = num * num * num;
            int count = 0, temp = num, r = 0, sum = 0, sum1 = 0, r1 = 0;
            //  Console.WriteLine(cube);
            while (num > 0)
            {
                r = num % 10;
                num = num / 10;
                count++;
            }

            num = temp;


            for (int i = 1; i <= count; i++)
            {
                r = cube % 10;
                sum = (sum * 10) + r;
                cube = cube / 10;
            }

            while (sum > 0)
            {
                r1 = sum % 10;
                sum1 = (sum1 * 10) + r1;
                sum = sum / 10;
            }

            if (num == sum1)
            {
                Console.WriteLine($"{num} is Trimorphic Number ");
            }
            else
            {
                Console.WriteLine($"{num} is NOT Trimorphic Number ");
            }
        }
    }
}

