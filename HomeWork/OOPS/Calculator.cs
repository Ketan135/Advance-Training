using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS
{
    internal class Calculator
    {
        public void add(int a, int b, int c)
        {
            int sum = a + b + c;
            Console.WriteLine(c);
        }
        public int fact(int n)
        {
            int fact = 1;
            for (int i = n; i >= 1; i--)
            {
                fact = fact * n;

            }
            return fact;

        }
        public bool isprime(int n)
        {
            bool prime = true;
            for (int i = 2; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
        public string greet(string n)
        {
            Console.WriteLine("Good afternoon" + n);
            return n;
        }

    }

    class Show
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.add(1, 2, 3);
            int f = c.fact(4);
            bool b = c.isprime(4);
            string s = c.greet(" All");
            Console.WriteLine($"fact {f}");
            Console.WriteLine($"isprime {b}");
            Console.WriteLine(s);
        }

    }



}
