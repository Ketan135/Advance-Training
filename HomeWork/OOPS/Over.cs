using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class In
    { 
        public virtual void display()
        {
            Console.WriteLine("In Parent");
        }

        public class Child : In
        {
            public override void display()
            {
                Console.WriteLine("In child");
            }

            static void Main(string[] args)
            {
                In ob = new In();
                ob.display();
            }
        }
    }
}
