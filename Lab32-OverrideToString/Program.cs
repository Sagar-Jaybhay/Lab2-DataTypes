using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32_OverrideToString
{
    class Student
    {
        public string FullName { get; set; }
        public string Std { get; set; }
        public string ID { get; set; }

        public override string ToString()
        {
            return "Full Name ------>"+ FullName + "-- Std IS --->" + Std + "----Student Id ----" + ID;
            //return base.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.FullName = "Sagar";
            st.Std = "MCS";
            st.ID = "1";
            Console.WriteLine(Convert.ToString(st));
            Console.Read();
        }
    }
}
