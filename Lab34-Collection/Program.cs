using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab34_Collection
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("sagar", "jaybhay");
            h.Add(1, "101");

            Console.WriteLine(h["sagar"]);


            object[] arryobj = new object[3];
            arryobj[0] = 1;
            arryobj[1] = "sagar";
            arryobj[2] = 20.12;
            Console.WriteLine("======Printing object type array============");

            foreach (object obj in arryobj)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("====== End Printing object type array============");


            int[] intarray = new int[5];

            for (int i=0;i<intarray.Length;i++)
            {
                intarray[i] =  i+1;
            }

            foreach(int i in intarray)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
