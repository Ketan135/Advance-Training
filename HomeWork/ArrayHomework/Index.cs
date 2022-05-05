using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Index
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 565, 12, 78, 54, 9, 88, 23, 77, 4 };
            int ind = 0;

            Console.WriteLine("Enter element you want to search in array");
            int s = Convert.ToInt32(Console.ReadLine());
            bool isPresent = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == s)
                {
                    isPresent = true;
                    ind = i;
                    break;
                }

            }

            if (isPresent)
            {
                Console.WriteLine($"{s} is present in array& its position is{ind}");
            }
            else
                Console.WriteLine($"{s} is not present in array");
        }
    }
}