using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            #region /* if else statement */
            Console.Write("Enter your favourite season name(season name should be lower case):)-");
            string season = Console.ReadLine();
            if (season == "summar")
            {
                Console.WriteLine("It is so hot season.During this season persons and animal are feeling uneasy\n");
            }
            else if (season == "rainy")
            {
                Console.WriteLine("This is the season of rain and thunder\n");
            }
            else if(season == "autum")
            {
                Console.WriteLine("This is the season of Kash flower\n");
            }
            else if(season == "late autum")
            {
                Console.WriteLine("This is the season of Nobanna Uthsob\n");
            }
            else if(season == "winter")
            {
                Console.WriteLine("Flow cold air during this season over the country\n");
            }
            else if(season == "spring")
            {
                Console.WriteLine("This is the king season of the bangali year\n");
            }
            else
            {
                Console.WriteLine("Season name not maching\n");
            }
            #endregion


            #region   /* switch case statement */
            Console.Write("Enter a month name(Must be upper case):)-");
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
                case "June":
                    Console.WriteLine("Your printed month position is : 06");
                    break;
                case "July":
                    Console.WriteLine("Your printed month position is : 07");
                    break;
                case "August":
                    Console.WriteLine("Your printed month position is : 08");
                    break;
                case "Sepetember":
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
            Console.ReadKey();
            #endregion


            #region /*foreach loop*/

            /* creating an array */
            int[] numArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            /* foreach loop begin */
            foreach (int value in numArray)
            {
                Console.WriteLine("Foreach result: {0}",value);
            }
            Console.ReadKey();

            #endregion

        }
    }
}
