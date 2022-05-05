using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.CSharpTestDoc
{
    internal class AlphabetNumberPattern
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Odd Number To generate pattern:");
            int num = Convert.ToInt32(Console.ReadLine());

            char char1 = 'A';
            for (int i = num; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(char1);
                        char1++;
                    }
                }
                Console.WriteLine("");
                char1 = 'A';
            }
            for (int i = 2; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    if (i % 2 != 0)
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(char1);
                        char1++;
                    }
                }
                Console.WriteLine(" ");
                char1 = 'A';

            }
        }
    }

}