using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class MinMax
    {
        static void Main(string[] args)
        {
            int[] arr = { 99, 85, 72, 41, 10 };
            int i, max, min, n;
            n = 5;
            max = arr[0];
            min = arr[0];
            for(i=1;i<n;i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max element={o}",max);
            Console.WriteLine("Min element={0}",min);
        }
    }
}
