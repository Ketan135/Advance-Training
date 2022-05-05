using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class CharReplace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string s = Console.ReadLine();
            //Console.WriteLine("length" + s.Length);
            s=s.Trim();
            Console.WriteLine("Length=" + s.Length);
            int idx = s.IndexOf('k');
            int lastidx = s.LastIndexOf('t');
            Console.WriteLine(idx);
            Console.WriteLine(lastidx);
            string ss = "ketan";
            Console.WriteLine(ss.Substring(3));
            Console.WriteLine(ss.Substring(1, 3));
            char[] arr=ss.ToCharArray();
            arr[0] = 'c';
            string m=new string(arr);
            Console.WriteLine(m);


        }
    }
}
