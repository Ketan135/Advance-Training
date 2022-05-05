using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Assi8
    {
        static void Main(string[] args)
        {
            int[] a = { 10, -20,- 30, 40, 50 , -60 ,70 , 80 , -90 ,-100};
            int count = 0;

            Console.WriteLine("Negative elements in tha array are:");
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Console.WriteLine(a[i]);
                    count++;
                }
                 
            }

            Console.WriteLine($"Count of negative elements in array is: {count}");
        }
    }
}
