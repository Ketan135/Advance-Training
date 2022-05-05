using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Replace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
                //s = s[i];
                Console.WriteLine((char)(s[i]+1));

        }

    }
}
