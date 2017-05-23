using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_Interfaces
{
    interface I1
    {
        void Print();
       string Fields { get; set; }
    }
    interface I2
    {
        void Print();
        
    }


    class Abc :I1,I2
    {
      public string Fields { get; set; }

        void I1.Print()
        {
            Console.WriteLine("i1 Method");
        }

        void I2.Print()
        {
            Console.WriteLine("i2 Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            I1 i1 = new Abc();
            i1.Print();

            I2 i2 = new Abc();
            i2.Print();

            Console.Read();
        }
    }
}
