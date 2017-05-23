using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab30_Attributes
{
    [AttributeUsage(AttributeTargets.Field)]
    class myownAttribute:Attribute
    {

        public int Length { get; set; }

    }

    //[myown(Length = 10)]
    class Employee
    {
        [myown(Length =10)]
        public string EmpName;

        [Obsolete("This method is depricated",true)]
        public void AddEmp()
        {

        }
        public void AddEmp(string Empname)
        {
            // my addition logic
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.AddEmp("Sagar");

        }
    }
}
