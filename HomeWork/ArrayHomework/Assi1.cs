using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assi1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            n[0] = 1;
            n[1] = 2;
            n[2] = 3;
            n[3] = 4;
            n[4] = 5;

            Console.WriteLine("Elements");

            int i = 0;
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}", n[i]);
            }
            Console.ReadLine();
        }
    }
}