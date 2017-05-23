using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_SwitchStatment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int i = int.Parse(Console.ReadLine());
            //if (i == 0)
            //{

            //    Console.WriteLine("Your number is " + i);
            //}
            //else if (i == 1)
            //{
            //    Console.WriteLine("Your number is " + i*10);
            //}
            //else if (i == 2)
            //{
            //    Console.WriteLine("Your number is " + (i - 1));
            //}
            switch (i)
            {
                case 0:
                    Console.WriteLine("Your number is " + i);
                    break;
                case 1:
                    
                        Console.WriteLine("Your number is " + i * 10);
                    break;
                case 2:
                    
                        Console.WriteLine("Your number is " + (i - 1));
                    break;
                default:
                    Console.WriteLine("You are in default section");
                    break;
            }
            Console.Read();
        }
    }
}
