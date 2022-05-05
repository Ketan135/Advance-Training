using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
  class Emp1:IComparable
    {
        public int id, salary;

        public Emp1(int id,int salary)
        {
            this.id = id;
            this.salary = salary;
        }
        public int CompareTo(object obj)
        {
            Emp1 e = (Emp1)obj;
            if(this.salary>e.salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        class Emp11
        {
            static void Main(string[] args)
            {
                Emp1 e1 = new Emp1(1, 25000);
                Emp1 e2 = new Emp1(1, 30000);
                int result=e1.CompareTo(e2);
                if(result==1)
                {
                    Console.WriteLine($"{e1.id}earns more than{e2.id}");
                }
                else
                {
                    Console.WriteLine($"{e2.id}earns more than{e1.id}");
                }
            }
        }
    }
}
