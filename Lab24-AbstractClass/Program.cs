using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab24_AbstractClass
{
    interface I1
    {
        void InterFaceMethod();
    }
   public abstract  class xyz:I1
    {
        public abstract void InterFaceMethod();
        public abstract void SayHello();
    }
  
    public abstract class abc:xyz
    {
        string name;
        public string Name { get; set; }
        public abstract void Print();
        public abc()
        {

        }

        public void Hello()
        {
            Console.WriteLine("Hello world!!!!");
        }
    }

    class Program:abc
    {
        public override void SayHello()
        {
            Console.WriteLine("Say Hello Method");
        }

        public override void Print()
        {
            Console.WriteLine("Print Method");
        }
        static void Main(string[] args)
        {

            abc p = new Program();
            p.Print();
            p.SayHello();
            p.InterFaceMethod();
            Console.Read();
        }

        public override void InterFaceMethod()
        {
            Console.WriteLine("Interface method");
        }
    }
}
