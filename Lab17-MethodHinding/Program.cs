using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17_MethodHinding
{
    
    class A
    {
       public void Print()
        {
            Console.WriteLine("Parent Method");
        }      
        
    }

    class B:A
    {
        public new void Print()
        {
            Console.WriteLine("Child Method Method");
            //base.Print();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          A b = new B();
           b.Print();
          
            Console.Read();

        }
    }
}
