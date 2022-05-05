using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayHomework
{
    internal class Assi7
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Original Array Is:");
            System.Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine("Enter position to enter element");
            int pos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter element you want to insert:");
            int ele = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            arr[pos] = ele;

            System.Array.ForEach(arr, Console.WriteLine);
        }
    }
}
