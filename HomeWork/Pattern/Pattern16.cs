using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern
{
    internal class Pattern16
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = num; i>=1; i--)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
