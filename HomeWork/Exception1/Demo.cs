using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exception1
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inside main method");
            try
            {
                int a=int.Parse(Console.ReadLine());
                int b=int.Parse(Console.ReadLine());
                Console.WriteLine("Division="+a/b);
                Console.WriteLine("try end");
            }
            catch (Exception e)
            {
                Console.WriteLine("Divide by zero");
            }
            finally
            {
                Console.WriteLine("Inside Finally");
            }
        }
    }
}
