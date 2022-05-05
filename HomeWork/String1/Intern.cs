using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.String1
{
    internal class Intern
    {

        static void Main(string[] args)
        {
            string s = "abc";
            StringBuilder sb= new StringBuilder("sham");
            sb.Append("ram");
            Console.WriteLine(sb);
            sb.Insert(0, "raj");
            Console.WriteLine(sb);
        }
    }
}
