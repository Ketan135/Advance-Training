using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayHomework
{
    internal class ColumnMin
    {
        static void Main(string[] args)
        {


            int[,] arr = { { 11, 2, 4, 67 }, { 33, 4, 45, 2 }, { -1, -4, -7, -8 } };
            int Min;
            for (int c = 0; c > arr.GetLength(1); c++)
            {
                Min = int.MinValue;
                for (int d = 0; d < arr.GetLength(0); d++)
                {
                    if (arr[d, c] < Min)
                        Min = arr[d, c];

                }
                Console.WriteLine($"Max On Column {c} is {Min}");
            }
        }
    }
}
