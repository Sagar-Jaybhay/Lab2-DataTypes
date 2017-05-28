using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab38_GenericCollection
{

    class Abc
    {
        public string nanm { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listint = new List<int>();
            List<string> liststring = new List<string>();
            List<Abc> listcustomobj = new List<Abc>();

            Dictionary<int, int> intdic = new Dictionary<int, int>();
            Dictionary<string, string> stringdic = new Dictionary<string, string>();

            listint.Add(1);
            liststring.Add("string");
            intdic.Add(1,1);
            stringdic.Add("a","a");

            Stack<int> stackint = new Stack<int>();
            stackint.Push(1);
            stackint.Pop();
            Queue<int> astring = new Queue<int>();
            astring.Enqueue(1);
            astring.Dequeue();


        }
    }
}
