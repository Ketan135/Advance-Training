using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class TwinPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Boolean isNum1Prime = true, isNum2Prime = true;

            for (int i = 2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    isNum1Prime = false;
                    break;
                }
            }

            for (int j = 2; j < num2; j++)
            {
                if (num2 % j == 0)
                {
                    isNum2Prime = false;
                    break;
                }
            }



            if (isNum1Prime == true && isNum2Prime == true)
            {
                if (num1 - num2 == 2 || num2 - num1 == 2)
                {
                    Console.WriteLine($"{num1} and {num2} are Twin Prime Numbers");
                }
                else
                {
                    Console.WriteLine($"{num1} and {num2} are  Prime Numbers but they are Not Twin");
                }
            }
            else if (isNum1Prime == true && isNum2Prime == false)
            {
                Console.WriteLine($"{num1} is a Prime Number , {num2} is Not a Prime Number");
            }
            else if (isNum1Prime == false && isNum2Prime == true)
            {
                Console.WriteLine($"{num1} is Not a Prime Number , {num2} is a Prime Number");

            }
        }
    }
}

