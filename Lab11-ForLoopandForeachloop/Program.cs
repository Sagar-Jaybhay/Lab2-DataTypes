using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_ForLoopandForeachloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arry = { 1, 2, 3, 4, 5 };
            Console.WriteLine("For loop started");
            for (int i=0; i<arry.Length;i++)
            {
                Console.WriteLine(arry[i]);
            }
            Console.WriteLine("For loop end");
            Console.WriteLine("Foreach loop started");

            foreach (int k in arry)
            {
                //k = k + 1;
                Console.WriteLine(k);
            }
            Console.WriteLine("Foreach loop end");
            Console.Read();

        }
    }
}
