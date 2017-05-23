using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab25_Delegates
{

    public delegate void MyFirstDelegate(string name);

    class Program
    {
        
        static void Main(string[] args)
        {
            MyFirstDelegate f1 = new MyFirstDelegate(Print);            
            f1("Sagar");
            f1 += new MyFirstDelegate(SayHello);
            f1("Hiiiiiiiiiiii");
            Console.Read();
        }
      
        static void Print(string Name)
        {
            Console.WriteLine("Invocation by delegate  "+Name);
        }
        static void SayHello(string fname)
        {
            Console.WriteLine("Invocation by delegate  second method " + fname);
        }
    }
}
