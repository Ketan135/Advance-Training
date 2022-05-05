using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    internal class Demo
    {

        static void Main(string[] args)
        { }
            public interface IDBOperation
        { 
            int Save();
        }
        public interface IOrder
        {
            string OrderDetails();
        }
        public class User : IOrder, IDBOperation
        {
            public string OrderDetails()
            {
                return "Code goes here";
            }
            public int Save()
            {
                return 1;
            }

        }
        public class Product : IDBOperation
        {
            public int Save()
            {
                return 1;
            }
        }
    }
}

    

