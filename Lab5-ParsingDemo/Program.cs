using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_ParsingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string abc = "10";
           // i = Convert.ToInt32(abc);
            int res;
            Console.WriteLine(i);
            bool b=  int.TryParse(abc, out res);
            if(b)
            {
                Console.WriteLine("TryParse Succcessfully "+res);
            }else
            {
                Console.WriteLine("The value is not integer & current value is "+abc);
            }
            

            Console.Read();
        }
    }
}
