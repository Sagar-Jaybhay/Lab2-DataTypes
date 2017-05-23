using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15_StaticAndInstanceClass
{
    class Customer
    {
        static double _discount ;
        public double _purchaseAmount;
        public Customer()
        {
            Console.WriteLine("Instance constructor called");
            this._purchaseAmount = 0;
        }
        static Customer()
        {
            Console.WriteLine("Static constructor called");
            Customer._discount = 10;
        }

        public double calculateDiscount()
        {
            return (this._purchaseAmount * Customer._discount) / 100;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();          
            cust._purchaseAmount = 100;           
            Console.WriteLine("Final Discount is ="+cust.calculateDiscount());

            Customer cust1 = new Customer();
            cust1._purchaseAmount = 200;
            Console.WriteLine("Final Discount is =" + cust1.calculateDiscount());



            Console.Read();
        }
    }
}
