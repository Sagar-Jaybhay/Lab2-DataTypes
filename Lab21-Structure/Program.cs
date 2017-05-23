using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21_Structure
{
    struct Employee
    {

        public Employee(string EmpName)
        {
           this.EmpName = EmpName;
        }
        public string EmpName;

        public string empName
        {
            get
            {
                return EmpName;
            }
            set
            {
                EmpName = value;
            }

        }

        public void Print(string name)
        {
            Console.WriteLine(name);
        }

    }

    class Program
    {
        public string empName;

        public string EmpName
        {
            get
            {
                return empName;
            }
            set
            {
                empName = value;
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
