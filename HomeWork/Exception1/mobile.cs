using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Exception1
{
    internal class mobile
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Mobile number");
            try
            {
                long num = Convert.ToInt32(Console.ReadLine());
                if (num == 10)
                {
                    Console.WriteLine("Number is valid");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Number invalid");
            }
        }
    }
}            
