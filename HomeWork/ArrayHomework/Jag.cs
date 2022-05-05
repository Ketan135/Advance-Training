using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.ArrayHomework
{
    internal class Jag
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 2];
            int[][] jrr = new int[3][];

            jrr[0]=new int[3];
            jrr[1]=new int[5];
            jrr[2]=new int[2];
            for(int i=0; i<jrr[i].GetLength(0); i++)
            {
                for(int c=0; c<jrr[i].Length; c++)
                {
                    jrr[i][c] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < jrr[i].GetLength(0); i++)
            {
                for (int c = 0; c < jrr[i].Length; c++)
                {
                    Console.WriteLine(jrr[i][c]);
                }
            }

        }
    }
}
