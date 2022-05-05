using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Trim
    {
        static void Main(string[] args)
        {   
            string str = "   I am Ketan  ";
            Console.WriteLine("Original Sring is:");
            Console.WriteLine(str);

            Console.WriteLine("String after left trim");
            string[] strr = str.Split(" ");
            int j = 0;
            for (int i = 0; i < strr.Length; i++)
            {
                if(strr[i].Length != 0)
                {
                    j = i;
                    break;
                }
            }
            for(int k = j; k < strr.Length; k++)
            {
                Console.Write(strr[k]+" ");
            }
        }
    }
}
