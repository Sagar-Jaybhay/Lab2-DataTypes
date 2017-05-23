using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_RefandOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int a;
         
           // Console.WriteLine("Outside function value is "+a);
            p.modify(out a);
            Console.Read();
        }


        public void  modify(out int a)
        {
           a = 10;
            Console.WriteLine("In Function value is "+a);
        }
    }
}
