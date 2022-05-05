using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{

    class Binary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Binary Number : ");
            int binaryNumber = Convert.ToInt32(Console.ReadLine());
            int decimalValue = 0;
            int base1 = 1;
            bool isBinary = true;
            int temp = binaryNumber;
            int count = 0;

            while(binaryNumber > 0)
            {
                binaryNumber = binaryNumber / 10;
                count++;
            }

            binaryNumber = temp;

            for(int i = 0; i < count; i++)
            {
                int rem= binaryNumber % 10;
               
              
                if(rem!=0 && rem != 1)
                {
                    
                    isBinary = false;
                    break;
                }
                binaryNumber = binaryNumber / 10;
            }
          
            binaryNumber = temp;

            if (isBinary==true)
            {
                while (binaryNumber > 0)
                {
                    int reminder = binaryNumber % 10;
                    binaryNumber = binaryNumber / 10;
                    decimalValue += reminder * base1;
                    base1 = base1 * 2;
                }
                Console.Write($"Decimal Value : {decimalValue} ");

            }
            else
            {
                Console.WriteLine("Number is Not a Binary Number");
            }
           
          

        }

    }

}