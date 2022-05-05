

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class ReverseArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Elements in Array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Now Enter Elements Of Array");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {


                {
                    temp = arr[i];
                    arr[i] = arr[arr.Length - i - 1];
                    arr[arr.Length - i - 1] = temp;

                }

            }
            Console.WriteLine("");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }
        }
    }
}
