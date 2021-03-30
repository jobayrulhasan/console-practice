using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSir
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.Write("Enter a number:)-");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number:)-");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an operator(Multiplication/Division/Remainder/Summation/Sbutruction):)-");
                string myCalculation = Console.ReadLine();
                int result = calculation(a, b, myCalculation);
                Console.WriteLine("Your calculated result is:{0}", result);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception found");

            }
        }
        public static int calculation(int a, int b, string myCalculation)
        {
            try
            {
                if (myCalculation == "Multiplication")
                {
                    return a * b;
                }
                else if (myCalculation == "Divition")
                {
                    return a / b;
                }
                else if (myCalculation == "Remainder")
                {
                    return a % b;
                }
                else if (myCalculation == "Summation")
                {
                    return a + b;
                }
                else if (myCalculation == "Subtruction")
                {
                    return a - b;
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception ex)
            {
                return ex.HResult;
            }
            

        }
        
    }
}
