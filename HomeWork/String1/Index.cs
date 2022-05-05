using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Index
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string s = Console.ReadLine();
            int idx=s.IndexOf('k');
            int lastidx = s.LastIndexOf('t');
            Console.WriteLine(idx);
            Console.WriteLine(lastidx);
            string ss = "ketan";
            Console.WriteLine(ss.Substring(3));
            Console.WriteLine(ss.Substring(1,3));


        }
    }
}
