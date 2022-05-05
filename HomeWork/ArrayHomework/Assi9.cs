using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Assi9
    {
        static void Main(string[] args)
        {
            int[] arr = { 33, 56, 22, 15, 73, 42, 99 };
             
            int []even = new int[arr.Length];
            int []odd = new int[arr.Length];

            int ecount = 0, ocount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[ecount] = arr[i];
                    ecount++;
                }
                else
                {
                   odd[ocount] = arr[i];
                    ocount++;

                }
            }

            Console.WriteLine("Original Array Is:");
            System.Array.ForEach(arr, Console.WriteLine);

            Console.WriteLine("Even Array Is:");
            System.Array.ForEach(arr, Console.WriteLine);

            Console.WriteLine("Odd Array Is:");
            System.Array.ForEach(arr, Console.WriteLine);


        }
    }
}
