using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region/*if elese statement*/
            Console.Write("Enter your favourite season name(season name must be lower case):)-");
            string season = Console.ReadLine();
            if (season == "summar")
            {
                Console.WriteLine("It is so hot season.During this season persons and animal are feeling uneasy\n");
            }
            else if (season == "rainy")
            {
                Console.WriteLine("This is the season of rain and thunder\n");
            }
            else if (season == "autum")
            {
                Console.WriteLine("This is the season of Kash flower\n");
            }
            else if (season == "late autum")
            {
                Console.WriteLine("This is the season of Nobanna Uthsob\n");
            }
            else if (season == "winter")
            {
                Console.WriteLine("Flow cold air during this season over the country\n");
            }
            else if (season == "spring")
            {
                Console.WriteLine("This is the king season of the bangali year\n");
            }
            else
            {
                Console.WriteLine("Season name not maching\n");
            }
            #endregion

            #region   /*switch statement*/
            Console.Write("Enter a month name(Month name must be upper case):)-");
            string monName = Console.ReadLine();
            switch (monName)
            {
                case "January":
                    Console.WriteLine("Your printed month position is : 01");
                    break;
                case "February":
                    Console.WriteLine("Your printed month position is : 02");
                    break;
                case "March":
                    Console.WriteLine("Your printed month position is : 03");
                    break;
                case "April":
                    Console.WriteLine("Your printed month position is : 04");
                    break;
                case "May":
                    Console.WriteLine("Your printed month position is : 05");
                    break;
                case "june":
                    Console.WriteLine("Your printed month position is : 06");
                    break;
                case "July":
                    Console.WriteLine("Your printed month position is : 07");
                    break;
                case "August":
                    Console.WriteLine("Your printed month position is : 08");
                    break;
                case "September":
                    Console.WriteLine("Your printed month position is : 09");
                    break;
                case "October":
                    Console.WriteLine("Your printed month position is : 10");
                    break;
                case "November":
                    Console.WriteLine("Your printed month position is : 11");
                    break;
                case "December":
                    Console.WriteLine("Your printed month position is : 12");
                    break;
                default:
                    Console.WriteLine("Month name not maching!Try again");
                    break;
            }
            #endregion

            #region/*while statement*/
            Console.WriteLine("\nWhile statement is starts here");
            int number1 = 0;
            while (number1 <= 50)
            {
                Console.WriteLine(number1);
                number1 += 2;
            }
            Console.WriteLine("While statement is ends here\n");
            #endregion

            #region /*for statement*/
            Console.WriteLine("For statement is starts here");
            for (int number2 = 0; number2 <= 50; number2++)
            {
                Console.WriteLine(number2);
            }
            Console.WriteLine("For statement is ends here");
            #endregion

            #region/*foreach statement*/

            /*create an array*/
            int[] numArray = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            /*foreach begain*/
            Console.WriteLine("\nForeach starts here");
            foreach (int value in numArray)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Foreach ends here\n");
            #endregion

            #region/*do while statement*/

            Console.WriteLine("do statement is starts here");
            int number3 = 0;
            do
            {
                Console.WriteLine(number3);
                number3 += 5;
            } while (number3 <= 50);
            Console.WriteLine("do statement is ends here");

            Console.WriteLine("\n.........The end........");
            #endregion
            Console.ReadKey();
        }
    }
}
