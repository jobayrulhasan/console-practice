using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine()) ;
            Console.Write("\nPlease enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease enter your third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYour calculation is following:)---\n");
            int sumation, subtraction, multiplication, division, remainder;
            Console.WriteLine("number1 + number2 + number3 is calculated here");
            sumation = num1 + num2 + num3;
            Console.WriteLine("Sumation result is : " + sumation);

            Console.WriteLine("\nnumber3 + number1 - number2 is calculated here");
            subtraction = (num3 + num1) - num2;
            Console.WriteLine("Subtraction result is : " + subtraction);

            Console.WriteLine("\nnumber1 + number3 * number2 is calculated here");
            multiplication = (num1 + num3) * num2;
            Console.WriteLine("Multiplication result is : " + multiplication);

            Console.WriteLine("\nnumber1 + number2 / number3 is calculated here");
            division = (num1 + num2) / num3;
            Console.WriteLine("Division result is : " + division);

            Console.WriteLine("\nnumber1 + number2 % number2 is calculated here");
            remainder = (num1 + num2) % num3;
            Console.WriteLine("Remainder result is : " + remainder);
            Console.WriteLine("\nDone by\nJobayrul Hasan(Orthi)\nIDB-BISEW, Round-47");
            Console.WriteLine("\n.........The end .........");
            Console.ReadKey();
        }
    }
}
