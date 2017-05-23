using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_Polymorphism
{
   public  class  A
    {

        public void Add(double i,int j)
        {
            Console.WriteLine("Addition is "+(i+j));
        }

        public void Add(int i,int j,int k)
        {
            Console.WriteLine(i+j+k);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Add(10,20);
            a.Add(10,30,30);

            Console.Read();
        }
    }
}
