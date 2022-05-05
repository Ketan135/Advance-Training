using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class CountWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string str = Console.ReadLine();

            string []strarr = str.Split(' ');
            int count = 0;

            for (int i = 0; i < strarr.Length; i++)
            {
                count++;
            }

            Console.WriteLine("Count of words is string is: " + count);


        }
    }
}
