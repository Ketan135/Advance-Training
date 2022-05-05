using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Longest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Sentense");
            string s=Console.ReadLine();

            string[] strr = s.Split(" ");
            string longword=strr[0];

            for(int i=0;i<strr.Length;i++)
            {
                if(longword.Length <= strr[i].Length)
                {
                    longword=strr[i];
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("Longest word is " + longword);
        }
    }
}
