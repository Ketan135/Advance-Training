using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Sum
    {
        static void Main(string[] args)
        {
            static int[] AddArrays(int[] a, int[] b)
            {
                int[] newArray=new int[a.Length];
                for(int i = 0; i < a.Length; i++)
                {
                    newArray[i] = a[i] + b[i];
                }
                return newArray;
            }
        }
       
    }
}
