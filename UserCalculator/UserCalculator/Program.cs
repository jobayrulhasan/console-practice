using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please inter your first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease inter your second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease inter your third number : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int Sumation, Subtraction, Multiplication, Division, Remainder;
              /*  num1 = 33;
                  num2 = 44;
                  num3 = 55;
              */
            Console.WriteLine("\nYour calculation is following\n");
            Sumation = num1 + num2 + num3;
            Console.WriteLine("Sumation result is : " + Sumation);

            Subtraction = (num1 + num2) - num3;
            Console.WriteLine("Subtraction  result is : " + Subtraction);

            Multiplication = (num1 + num2) * num3;
            Console.WriteLine("Multiplication result is : " + Multiplication);

            Division = (num1 + num2) / num3;
            Console.WriteLine("Division resutl is : " + Division);

            Remainder = (num1 + num2) % num3;
            Console.WriteLine("Remainder result is : " + Remainder);

            Console.WriteLine("\n..............The end .............");

            Console.ReadKey();
        }
    }
}
