using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Practice
{
    internal class Devide
    {
        static void Main(string[] args)
        {
            int[] s = {1, 2, 3,4,5,6};
            for(int i = 0; i < s.Length/2; i++)
            {
                int temp = s[i];
                s[i] = s[i+1];
                s[i+1] = temp;

            }
           for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
        
    }
}
