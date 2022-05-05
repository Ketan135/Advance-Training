using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class New
    {
        static void Main(string[] args)
        {
            
            string str = "Ketan";
            Console.WriteLine(str);

            Console.WriteLine("Enter word u want");
            string str2 =Console.ReadLine();

            char[] strr1 = str.ToCharArray();
            char[] strr2 = str2.ToCharArray();
            bool isForm = false;
         

            for(int i = 0; i < strr2.Length; i++)
            {
                if(isForm)
                {
                    isForm = false;
                    for (int j = 0; j < strr1.Length; j++)
                    {
                        if (strr2[i] == strr1[j])
                        {
                            isForm = true;
                            break;
                        }

                    }
                }
            }
            if(isForm)
            {
                Console.WriteLine("The word form");
                

            }
            else
            {
                Console.WriteLine("The word cant form");
            }
        }
    }
}
