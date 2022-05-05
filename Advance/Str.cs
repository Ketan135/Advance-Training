using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public delegate void MyDelegate(string a);
    public class String
    {
        public void UpperCase(string a)
        {
            a = a.ToUpper();
        }
        public void LowerCase(string b)
        {
            b= b.ToLower();
        }
        
    }
    class Str
    {
        static void Main(string[] args)
        {
            String s1 = new String();
            MyDelegate m1 = new MyDelegate(s1.UpperCase);
            m1+=new MyDelegate(s1.LowerCase);
            Delegate[] list=m1.GetInvocationList();

            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke("Ketan"));
            }



        }

    }
}
