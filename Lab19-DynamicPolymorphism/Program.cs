using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_DynamicPolymorphism
{
    class A
    {

        public virtual void Display()
        {
            Console.WriteLine("I am in Class A");
        }

    }

    class B:A
    {
        public override void Display()
        {
            Console.WriteLine("I am in Class B");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            A obj = new B();
            obj.Display();
            Console.Read();
        }
    }
}
