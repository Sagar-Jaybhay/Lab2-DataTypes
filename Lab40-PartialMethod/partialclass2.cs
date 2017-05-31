using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab40_PartialMethod
{
    public partial class Example
    {
        partial void display()
        {
            Console.WriteLine("I am partial method second time");
        }

        partial void display(int i)
        {
            Console.WriteLine("Overloaded method "+i);

        }
    }
}
