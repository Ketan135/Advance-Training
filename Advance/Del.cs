using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public delegate int MyDelegate1(int a, int b);
    public class Calculation
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Multiply(int a,int b)
        {
            return a * b;
        }
        public int Sub(int a,int b)
        {
            return a - b;
        }
    }
     class Del
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            MyDelegate1 mydel = new MyDelegate1(calc.Multiply);
            mydel += new MyDelegate1(calc.Multiply);
            Delegate[] list=mydel.GetInvocationList();
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(12,30));
            }

        }

    }
}
