using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Array
{
    internal class Assi14
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter How Manhy Rows You Want In Array: ");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter How Many Columns You Want In Array: ");
            int column = Convert.ToInt32(Console.ReadLine());

            int [,]arr = new int[row, column];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"Enter Data for Row {i} and column {j}");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }


        }
    }
}
