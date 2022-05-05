using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern
{
    internal class Pattern10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            int num = Convert.ToInt32(Console.ReadLine());
            int char1 = 64 + num;
            int k = char1 + 1;

            for (int i = 1; i <= num; i++)
            {
                k = k - i;
                for (int sp = 1; sp <= num - i; sp++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(Convert.ToChar(k));
                    Console.Write(" ");
                    k++;

                }

                Console.WriteLine(" ");

            }

        }
    }
}
