using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.OOPS.Containment;

namespace AccessModifier
{
    internal class Inheritance
    {
        static void Main(string[] args)
        {
            Flat f = new Flat();
            f.M11.Name = "Ketan";
            Console.WriteLine("Member Name is=" + f.M11.Name);

        }
    }
}
