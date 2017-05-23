using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab29_forAccessModifier;
namespace Lab29_AccessModifier
{
    class Abc
    {
        private int i;
        public int j;

        protected int k;

        public int myPrivateVar
        {
            get { return i; }
            set { i = value; }
        }

        public int getPrivateField()
        {
            return i;
        }

        public void setPrivateVaribale(int val)
        {
            i = val;
        }

    }

   class Program:Class1
    {
       
        static void Main(string[] args)
        {

            Program p = new Program();
            p.i = 100;

            
           
        }
    }
}
