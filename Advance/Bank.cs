using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining

{
    public delegate void bankDelegate4();
    public class BankEvent
    {

        int bal = 15000;
        public int Bal
        {
            get { return bal; }
        }

        public event bankDelegate4 zeroBalance;
        public event bankDelegate4 zeroBalance1;
        public void WithDraw(int a)
        {

            if (bal == a)
                zeroBalance();

            if (bal < a)
            {
                zeroBalance1();
                return;
            }


            bal -= a;
            Console.WriteLine($"Balance After Withdraw is : {bal}");

        }
    }

    public class BankTest
    {
        static void Error1()
        {
            Console.WriteLine("Your Balance is Zero After Withdrawl");
        }
        static void Error2()
        {
            Console.WriteLine("Balance is low , you can not withdraw");
        }
        static void Main(string[] args)
        {
            BankEvent bank = new BankEvent();

            Console.WriteLine($"Your Balance is : {bank.Bal}");
            Console.WriteLine("Enter Amount to be withdrawn");
            int wd = Convert.ToInt32(Console.ReadLine());

            bank.zeroBalance += new bankDelegate4(Error1);
            bank.zeroBalance1 += new bankDelegate4(Error2);

            bank.WithDraw(wd);


        }
    }
}