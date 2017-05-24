using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab33_OverrideEqualsMethod
{   
    class A
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            return this.Name == ((A)obj).Name;
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();

        }
    }

    class Program
    {
        
        
        static void Main(string[] args)
        {
            A a = new A();
            a.Name = "Sagar";

            A a1=new A();
            a1.Name = "Sagar";

            Console.WriteLine(" compare with == Method ---> " + (a==(a1)));
            Console.WriteLine(" compare with .Equals Method ---> "+(a.Equals(a1)));
            Console.Read();
           
        }
    }
}
