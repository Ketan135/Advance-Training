using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern
{
    internal class Pattern8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int k = num+1;

            for (int i = 1; i <= num; i++)
            {
                k = k - i;
                for (int sp = 1; sp <= num - i; sp++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k);
                    Console.Write(" ");
                    k++;

                }

                Console.WriteLine(" ");

            }
        }
    }
}
