using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*if else*/
            Console.Write("Enter a number:)-");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 5 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.ReadKey();
            Console.Write("Enter your day name:)-");
            string day = Console.ReadLine();
            /*switch case */
            switch (day)
            {
                case "saturday":
                    Console.WriteLine("This is the frist day of week");
                    break;
                case "sunday":
                    Console.WriteLine("This is the second day of week");
                    break;
                case "monday":
                    Console.WriteLine("This is the third day of week");
                    break;
                case "tuesday":
                    Console.WriteLine("This is the forth day of week");
                    break;
                case "wednesday":
                    Console.WriteLine("This is the fifth day of week");
                    break;
                case "thursday":
                    Console.WriteLine("This is the sixth day of week");
                    break;
                case "friday":
                    Console.WriteLine("This is the holy day");
                    break;
                default:
                    Console.WriteLine("Day name not maching");
                    break;
            }
            Console.ReadKey();

        }
    }
}
