using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Merge
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 90,91,92,93,94,95 };
            arr1=arr1.Concat(arr2).ToArray();
            foreach(var e in arr1)
            {
                Console.WriteLine(e);
            }
        }
    }
}
