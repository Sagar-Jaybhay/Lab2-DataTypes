using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab39_PartialClasses
{
    public partial class Customer:I2
    {

        public void Print()
        {
            Console.WriteLine("CUstomer Name= "+CustomerName+" Discount is ="+Discount);
        }

    }
}
