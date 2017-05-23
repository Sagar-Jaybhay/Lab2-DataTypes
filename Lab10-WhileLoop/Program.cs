using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter The Number");
            //int i = int.Parse(Console.ReadLine());
            //int k = 0;
            //Console.WriteLine("Even Numbers are printing..");
            //Console.WriteLine();
            //while (k <= i)
            //{
            //    if (k % 2 == 0)
            //    {
            //        Console.Write(k+",");
            //    }
            //    k++;

            //}
            //Console.Read();

            int i = 5;
            do
            {
                Console.WriteLine(i);
                i--;
            } while (i>6);
            Console.Read();
        }
    }
}
