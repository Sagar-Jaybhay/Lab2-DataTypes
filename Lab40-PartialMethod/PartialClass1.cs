using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab40_PartialMethod
{
    public partial class Example
    {
        partial void  display();
        partial void display(int i);
        //partial void display()
        //{
        //    Console.WriteLine("I am partial method");
        //}
        public void NormalMethod()
        {
            Console.WriteLine("i m in normal method");
            display();
            display(10);
        }

    }
}
