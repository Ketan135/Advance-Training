using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Increase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two number");
            int a = Convert.ToInt32(Console.ReadLine());
            bool isincrease = true;
            bool isdecrease = true;

            int next = a % 10;
            a = a / 10;

            while(a>0)
            {
                int prev = a % 10;
                if(prev>next)
                {
                    isincrease = false;
                }
                if(prev<next)
                {
                    isdecrease = false;
                }
                next = prev;
                a = a / 10;
            }
            if(isincrease&&isdecrease)
            {
                Console.WriteLine("All degit are same");
            }
            else if(isincrease)
            {
                Console.WriteLine("Number is increasing");
            }
            else if(isdecrease)
            {
                Console.WriteLine("Number is decreasing");
            }
            else
            {
                Console.WriteLine("Number is bouncy");
            }
        }
    }
}
