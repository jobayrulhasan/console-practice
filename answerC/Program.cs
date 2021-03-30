using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerC
{
    class Program
    {
        static void Main(string[] args)
        {
            #region /* try catch */
            try
            {
                Console.Write("Enter a number:)-");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number:)-");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter an operator(Multiplication/Division/Remainder/Summation/Sbutruction):)-");
                string myCalculation = Console.ReadLine();
                int result = calculation(num1, num2, myCalculation);
                Console.WriteLine("Your calculated result is:{0}", result);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception found");
            }
        }
        public static int calculation(int num1, int num2, string myCalculation)
        {
            try
            {
                if (myCalculation == "Multiplication")
                {
                    return (num1 * num2);
                }
                else if (myCalculation == "Divition")
                {
                    return (num1 / num2);
                }
                else if (myCalculation == "Remainder")
                {
                    return (num1 % num2);
                }
                else if (myCalculation == "Summation")
                {
                    return (num1 + num2);
                }
                else if (myCalculation == "Subtruction")
                {
                    return (num1 - num2);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            #endregion
        }
    }
}
