using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Occuc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string str = Console.ReadLine();


            Console.WriteLine("Enter character to search: ");
            char c= Convert.ToChar(Console.ReadLine());


            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] == c)
                {
                    Console.WriteLine($"{c} found at  location {i + 1}");
                    break;
                }
            }
        }
    }
}
