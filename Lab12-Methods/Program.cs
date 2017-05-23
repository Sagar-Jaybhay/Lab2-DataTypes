using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Print();
          int i= p.PrintName("Sagar");
            Console.WriteLine("Catch Value from method "+i);
            Console.Read();
        }

        public void Print()
        {
            Console.WriteLine("Hello World!!!");
        }
        public int PrintName(string Name)
        {
            Console.WriteLine("Hello "+Name);
            return 1;
        }
    
    }
}
