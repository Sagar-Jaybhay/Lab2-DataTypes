using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16_Inhertance
{
    public class Customer
    {
        public Customer()
        {
            Console.WriteLine("Parent class constructor");
        }

        public Customer(string CustName)
        {
            Console.WriteLine("Parent Paramtrize constructor "+CustName);
        }

        public string CustomerName;
        public double Discount=0;

        public void Print()
        {
            Console.WriteLine("Customer Name "+CustomerName+" Discount "+Discount);
        }

        ~Customer()
        {
            Console.WriteLine("Parent class distructor");
            Console.Read();
        }
    }

    public class GlodCustomer :Customer
    {

        public GlodCustomer():base("Demo customer")
        {
            Console.WriteLine("Child class constructor");
        }

        public double calCulateDiscount()
        {
            return 20;
        }
        public void Print()
        {
            Console.WriteLine("Customer Name " + CustomerName + " Discount " + Discount);
        }
        ~GlodCustomer()
        {
            Console.WriteLine("child class distructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GlodCustomer cust = new GlodCustomer();
            cust.CustomerName = "Sagar";

            ((Customer)cust).Print();
            cust.Discount = 10;
            cust.Print();
            Console.Read();
        }
    }
}
