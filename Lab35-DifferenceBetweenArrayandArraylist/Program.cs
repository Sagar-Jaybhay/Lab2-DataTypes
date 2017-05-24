using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Lab35_DifferenceBetweenArrayandArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            Console.WriteLine("=== adding elements arrylist ");
            ArrayList arlist = new ArrayList();
            for (int i = 0; i < 10000; i++)
            {
                arlist.Add(i);
            }

            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine(arlist[i]);
            }

            Console.WriteLine("Time required to add and retrive from arrylist ======>" + st.ElapsedTicks.ToString());
            st.Stop();
                      


            Console.WriteLine("============================== ");

            Stopwatch st1 = new Stopwatch();
            st1.Start();

            int  [] arr=new int[10000];

            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = i;
            }
            foreach(int
                str in arr)
            {
                //Console.WriteLine(str);
            }
            Console.WriteLine("Time required to add and retrive from array ======>" + st1.ElapsedTicks.ToString());
            st1.Stop();
            Console.Read();
        }
    }
}
