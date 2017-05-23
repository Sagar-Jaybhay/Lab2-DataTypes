using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_IFstatment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Age");
            int age = int.Parse(Console.ReadLine());

            if (age == 10)
            {
                Console.WriteLine("Your age is " + age);
            }
            else if(age==20)
            {
                Console.WriteLine("else if block Your  age is "+age);

            }
            else
            {
                Console.WriteLine("You are in  else  block Your  age is " + age);
            }
            Console.Read();

        }
    }
}
