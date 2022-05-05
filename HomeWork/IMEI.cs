using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class IMEI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 15 digit IMEI number:");
            long imei = Convert.ToInt64(Console.ReadLine());
            long temp = imei;
            long sum = 0, r = 0, rprod = 0, internalR = 0, internalSum = 0;


            for (int i = 1; i <= 15; i++)
            {
                r = imei % 10;
                if (i % 2 == 0)
                {
                    rprod = r * 2;

                    if (rprod > 9)
                    {
                        while (rprod > 0)
                        {
                            internalR = rprod % 10;
                            internalSum = internalSum + internalR;
                            rprod = rprod / 10;

                        }
                        sum = sum + internalSum;
                    }
                    else
                    {
                        sum = sum + rprod;
                    }

                }
                else
                {
                    sum = sum + r;
                }

                imei = imei / 10;
                internalR = 0;
                internalSum = 0;
            }


            if (sum % 10 == 0)
            {
                Console.WriteLine("This is VALID IMEI NUMBER");
            }
            else
            {
                Console.WriteLine("This is NOT VALID IMEI NUMBER");
            }
        }
    }
}
