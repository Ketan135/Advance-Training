using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.OOPS.Constructor
{
    public class Order
    {
        int orderid;
        string orderdate;
        Customer c = new Customer();
        Item itm = new Item();

        public Order()
        {

        }

        public Order(int orderid, string orderdate, Customer c, Item itm)
        {
            this.Orderid = orderid;
            this.Orderdate = orderdate;
            this.C = c;
            this.Itm = itm;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        public Customer C { get => c; set => c = value; }
        public Item Itm { get => itm; set => itm = value; }
    }
    public class Customer
    {
        string custname;
        long mobno;
        Address addr = new Address();

        public Customer()
        {

        }

        public Customer(string custname, long mobno, Address addr)
        {
            this.Custname = custname;
            this.Mobno = mobno;
            this.Addr = addr;
        }

        public string Custname { get => custname; set => custname = value; }
        public long Mobno { get => mobno; set => mobno = value; }
        public Address Addr { get => addr; set => addr = value; }
    }
    public class Address
    {
        string areaname;
        string city;
        int pincode;

        public Address()
        {

        }

        public Address(string areaname, string city, int pincode)
        {
            this.Areaname = areaname;
            this.City = city;
            this.Pincode = pincode;
        }

        public string Areaname { get => areaname; set => areaname = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    public class Item
    {
        int itemid;
        string itemname;

        public Item()
        {

        }

        public Item(int itemid, string itemname)
        {
            this.Itemid = itemid;
            this.Itemname = itemname;
        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
    }
    public class TestOrder
    {
        static void Main(string[] args)
        {
            Order o1 = new Order();

            Console.WriteLine("Enter Customer Name");
            o1.C.Custname = Console.ReadLine();

            Console.WriteLine("Enter Customer Mobile Number");
            o1.C.Mobno = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Customer Area Name");
            o1.C.Addr.Areaname = Console.ReadLine();


            Console.WriteLine("Enter Customer City Name");
            o1.C.Addr.City = Console.ReadLine();


            Console.WriteLine("Enter Customer Pin Code");
            o1.C.Addr.Pincode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter OrderID: ");
            o1.Orderid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Order Date: ");
            o1.Orderdate = Console.ReadLine();

            Console.WriteLine("Enter Item id: ");
            o1.Itm.Itemid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Item name: ");
            o1.Itm.Itemname = Console.ReadLine();



            Console.WriteLine("Customer Name is: " + o1.C.Custname);
            Console.WriteLine("Customer Mobile Number is: " + o1.C.Mobno);
            Console.WriteLine("Customer Area Name , Area City , Pincode is: " + o1.C.Addr.Areaname + " " + o1.C.Addr.City + " " + o1.C.Addr.Pincode);
            Console.WriteLine("Order id and Order Date is : " + o1.Orderid + " " + o1.Orderdate);
            Console.WriteLine("Item id and Item name is : " + o1.Itm.Itemid + " " + o1.Itm.Itemname);


        }
    }
}