using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayHomework
{
    internal class Assi2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many elements you want to enter in array");
            int size=Convert.ToInt32(Console.ReadLine());

            int []arr = new int[size];

            Console.WriteLine("Enter Elements of Array:");

            for(int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }

            Console.WriteLine("Elements of array are as follows");

            foreach(int print in arr)
            {
                Console.WriteLine(print);
            }
        }
    }
}
