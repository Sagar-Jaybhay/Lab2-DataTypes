using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab27_InnerExceptionAndCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new myCustomException("Custome Error ");
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }

    public class myCustomException:Exception
    {
        public myCustomException():base()
        {

        }

        public myCustomException(string Message):base(Message)
        {

        }

        public myCustomException(string Message,Exception e):base(Message,e)
        { }

    }

}
