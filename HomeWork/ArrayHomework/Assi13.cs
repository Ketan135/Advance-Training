using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Assi13
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 3, 5, 6, 1, 4, 7, 8, 9 };
            bool isPresent = false;

            Console.WriteLine("Enter Sum You Want");
            int sum = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j=0;j<arr.Length; j++)
                {
                    if ((arr[i] + arr[i + 1]) == sum)
                    {
                        Console.WriteLine($"Pair producing given sum is: {arr[i]} and {arr[i+1]}");
                        isPresent = true;
                        break;
                    }
                }
            }

            if (!isPresent)
            {
                Console.WriteLine("No Elements found that produce given sum");
            }
        }
    }
}
