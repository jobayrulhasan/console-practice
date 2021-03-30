using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try catch */

            int k = 10;
            int divide = 0;
            try
            {
                divide = 100 / k;
                Console.WriteLine("Not executed");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {divide}");
            Console.ReadKey();

        }
    }
}
