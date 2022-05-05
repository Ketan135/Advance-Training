using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Long111
    {
        static void Main(string[] args)
        {
            string ss = "I am Ketan";
            string[] s = ss.Split(" ");
            string sk = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (sk.Length < s[i].Length)
                {
                    sk = s[i];
                }
            }
            Console.WriteLine($"Longest Word={sk}with length={sk.Length}");


        }
    }

}