using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Reverse
    {                       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string s = Console.ReadLine();
            for(int i=s.Length-1;i>=0;i--)
                Console.WriteLine(s[i]);
        }
    }
}
