using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    internal class Jag1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 56, 34, 12, 89, 48 };
            int[] arr2 = new int[3];
           

            Array.Copy(arr, 2, arr2, 0, 3);
            Array.Clear(arr, 3, 2);
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
