using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab35_StackAndQueue
{
    class Program
    {


        static void Main(string[] args)
        {
            Stack st = new Stack();
            for(int i=0;i<5;i++)
            {
                st.Push(i+1);
            }

            for(int i=0;i<5;i++)
            {
                Console.WriteLine(st.Pop());
            }
        
          

           
            Console.Read();
        }
    }
}
