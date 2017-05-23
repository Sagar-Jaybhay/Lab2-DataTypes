using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_forAccessModifier
{
    public class Class1
    {
        protected internal int i;

    }

    public class temp
    {
        public void getaccess()
        {
            Class1 c = new Class1();
            c.i = 100;
            Console.WriteLine(c.i);

        }
    }

}
