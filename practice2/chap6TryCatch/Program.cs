using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int div = 100;
            //try
            //{
            //    div = 100 / x;
            //    Console.WriteLine("Not executed line");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Exception occured");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block");
            //}
            //Console.WriteLine($"Result is {div}");
            //Console.ReadKey();

            int num1 = 10;
            int div = 100;
            try
            {
                int dive  = 100 / num1;
                Console.WriteLine("Your reault is zero:{0}",dive);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Your entry was wrong");
            }
            finally
            {
                Console.WriteLine("Try catch execution is finished:{0}", div);
            }
            Console.WriteLine("your program is end");
            Console.ReadKey();
        }
    }
}
