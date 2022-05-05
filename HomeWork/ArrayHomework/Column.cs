using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayHomework
{
    internal class Column
    {
        static void Main(string[] args)
        {


            int[,] arr = { { 11, 2, 4, 67 }, { 33, 4, 45, 2 }, { -1, -4, -7, -8 } };
            int max;
            for (int c = 0; c < arr.GetLength(1); c++)
            {
                max = int.MinValue;
                for (int d = 0; d < arr.GetLength(0); d++)
                {
                    if (arr[d, c] > max)
                        max = arr[d, c];

                }
                Console.WriteLine($"Max On Column {c} is {max}");
            }
        }
    }
}
