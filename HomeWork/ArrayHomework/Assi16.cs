using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Assi16
    {
        static void Main(string[] args)
        {
           int  [,]arr = { { 22, 31 , 23}, { 12, 25  ,11 }, { 23, 35 ,21 } };
            int max = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
                Console.WriteLine($"Max Element From Row {i} is {max}");
                max = 0;
            }

        }
    }
}
