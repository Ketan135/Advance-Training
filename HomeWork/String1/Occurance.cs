using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Occurance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentense");
            string s=Console.ReadLine();

            for(int i=0; i<s.Length; i++)
            {
                if(s[i]>='a'&&s[i]<='z')
                {
                    Console.WriteLine("Small letter");
                }
                else if(s[i]>='A'&&s[i]<='Z')
                {
                    Console.WriteLine("Capital letter");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            
        }
    }
}
