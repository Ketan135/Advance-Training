using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeWork.Collection
{
    public class Demo
    {
        static void Main(string[] args)
        {
            ArrayList l1=new ArrayList();
            l1.Add("Ketan");
            l1.Add(90);
            l1.Add("ketan@gmail.com");
            l1.Remove("ketan");
            {
                Console.WriteLine(l1);
            }


        }
    }
}
