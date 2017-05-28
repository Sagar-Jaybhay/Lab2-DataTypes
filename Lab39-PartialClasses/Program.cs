using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab39_PartialClasses
{
 
    interface  I1
    {

    }

    interface I2
    {

    }

   
    class Program
    {
        static void Main(string[] args)
        {
            Customer cs = new Customer();
            cs.CustomerName = "Sagar";
            cs.Discount = 10;
            cs.Print();
            Console.Read();

        }
    }
}
