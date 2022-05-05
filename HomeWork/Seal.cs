using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Seal
    {
        public virtual void display()
        {
            Console.WriteLine("In Parent");
        }
    }
        public class Child:Seal
        {
            public override void display()
            {
                Console.WriteLine("In child");
            }
            static void Main(string[] args)
            {
                Child s1=new Child(); 
                s1.display();
            }
        }
    }

