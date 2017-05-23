using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab31_Generics
{
    public class geneAdd<T> where T : struct
    {
        public T Add(T i,T j)
        {
            dynamic d = i;
            dynamic e = j;
            return d+e;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            geneAdd<double> g = new geneAdd<double>();
           Console.WriteLine(g.Add(11.20,12.30));
            Console.Read();
        }
    }
}
