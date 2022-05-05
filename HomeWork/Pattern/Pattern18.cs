using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Pattern
{
    internal class Pattern18
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            char k = 'A';
            for (int i = num; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(k);
                    Console.Write(" ");
                    k++;
                }
                Console.WriteLine(" ");
                k = 'A';
            }
        }
    }
}
