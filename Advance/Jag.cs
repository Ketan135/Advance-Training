using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    internal class Jag
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[3][];
            int[,] arr = new int[2, 3]; // same of 1D
            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[2] = new int[] { 1, 2, 3, 4, 5, 6 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
            }

        }
    }
}
