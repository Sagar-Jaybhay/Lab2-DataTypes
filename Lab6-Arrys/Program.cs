using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Arrys
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            for (int a = 0; a <array.Count(); a++)
            {
                Console.WriteLine(array[a]);
            }
            //foreach (int a in array)
            //{
            //    Console.WriteLine(a);
            //}
            Console.Read();
        }
    }
}
