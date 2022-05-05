using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Collection
{
    internal class Emp
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(10);
            list1.Add(20);

            List<string> list2 = new List<string>();
            list2.Add("Hi");
            list2.Add("Hello");
            list2.Add("Pune");
            list2.Insert(1, "Ketan");
            //list2.Clear();
           
            foreach(string i in list2)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
