using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Classes
{
   public class xyz
    {
       public string name;
       public string address;

        public xyz(string FullName,String Address)
        {
            this.name = FullName;
            this.address = Address;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Your Name is "+this.name+" and your address is "+this.address);
        }
        ~xyz() {
            //clean up activity

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            xyz object1=new xyz("Sagar","India");
            

            object1.PrintDetails();
            Console.Read();
        }
    }
}
