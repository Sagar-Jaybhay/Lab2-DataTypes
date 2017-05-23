using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Properties
{
    class Program
    {
        private static string name;

        public static string Name
        {
            
            set
            {
                name = value;
            }
        }
       
        static void Main(string[] args)
        {
            //print(Name);
            

        }

        public static void print(string Na)
        {
            Console.WriteLine(Na);
        }
        public static void print2(out string Na)
        {
            Na = "sagar";
            Console.WriteLine(Na);
        }

    }
}
