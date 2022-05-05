using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Assi4
    {

        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };
            int[] b = new int[a.Length];

            System.Array.Copy(a , b, a.Length);

            Console.WriteLine("Original Array is:");
            System.Array.ForEach(a, Console.WriteLine);

            Console.WriteLine("Copied Array is:");
            System.Array.ForEach(a, Console.WriteLine);


        }

    }
}
