using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Sort
    {
        static void Main(string[] args)
        {
            string[] s = { "sham", "ram" }; ;
            for(int i = 0; i < s.Length-1; i++)
            {
                for(int j = 0; j < s[i].Length; j++)
                {
                    if(s[i].CompareTo(s[j])==1)
                    {
                        string temp=s[i];
                        s[i]=s[j];
                        s[j]=temp;
                    }
                }
            }
            foreach(string s2 in s)
            {
                Console.WriteLine(s);
            }
        }
    }
}
