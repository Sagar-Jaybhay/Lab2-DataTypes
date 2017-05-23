using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Lab26_ExceptionHandling
{
    class Program
    {
             
        
        static void Main(string[] args)
        {
            try
            {
                int i = 10;
                int j = 0;
                int k = i / j;

            }catch(ArithmeticException ex)
            {
                throw new DivideByZeroException("Exception", ex);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.GetType().Name);
                Console.WriteLine("---------Exception Class--------");
                Console.Read();
            }
            finally
            {
                Console.WriteLine("----------Finally Get Excuted------");
                Console.Read();
            }

        }
    }
}
