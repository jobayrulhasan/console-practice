using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your grade value:)-");
            gradeCalculation(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter your month number:)-");
            monthCount(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter your birth of year :)-");
            yearOfBirth(Convert.ToInt32(Console.ReadLine()));
          
            /* switch case */
            Console.Write("Write your favourite season name:)-");
            string month = Console.ReadLine();
            switch (month)
            {
                case "summar":
                    Console.WriteLine("It's hot season");
                    break;
                case "rainy":
                    Console.WriteLine("Huge rain over the country and duration is about 4 months");
                    break;
                case "autum":
                    Console.WriteLine("Less hot and less rain season");
                    break;
                case "late autum":
                    Console.WriteLine("This is the season of Nobanno,means new rice harvesting.");
                    break;
                case "winter":
                    Console.WriteLine("Cold air flow over the country during this season");
                    break;
                case "spring":
                    Console.WriteLine("This is the season of cuckoo singing");
                    break;
                default:
                    Console.WriteLine("Not maching season name");
                    break;
            }
            Console.WriteLine("........The end ......");
            Console.ReadKey();

        }
        public static int gradeCalculation(int gradeResult)
        {
            int result = gradeResult;
            if (gradeResult >= 80 && gradeResult <= 100)
            {
                Console.WriteLine("Your result is : A+\nWelcome for your brilliant success");
            }
            else if (gradeResult >= 75 && gradeResult <= 79)
            {
                Console.WriteLine("Your grade is : A");
            }
            else if (gradeResult >= 70 && gradeResult <= 74)
            {
                Console.WriteLine("Your grade is : A-");
            }
            else if (gradeResult >= 65 && gradeResult <= 69)
            {
                Console.WriteLine("Your grade is : B+");
            }
            else if (gradeResult >= 60 && gradeResult <= 64)
            {
                Console.WriteLine("Your grade is : B");
            }
            else if (gradeResult >= 55 && gradeResult <= 59)
            {
                Console.WriteLine("Your grade is : B-");
            }
            else if (gradeResult >= 50 && gradeResult <= 54)
            {
                Console.WriteLine("Your grade is : C+");
            }
            else if (gradeResult >= 45 && gradeResult <= 49)
            {
                Console.WriteLine("Your grade is : C");
            }
            else if (gradeResult >= 40 && gradeResult <= 44)
            {
                Console.WriteLine("Your grade is : D");
            }
            else
            {
                Console.WriteLine("You are not able to pass.\nTry with next chance.");
            }

            return result;
        }

        /* -----apply method for month search ----*/
        public static int monthCount(int month)
        {
            int number = month;
            if (month == 1)
            {
                Console.WriteLine("Your searched name is : January");
            }
            else if (month == 2)
            {
                Console.WriteLine("Your searched name is : February");
            }
            else if (month == 3)
            {
                Console.WriteLine("Your searched name is : March");
            }
            else if (month == 4)
            {
                Console.WriteLine("Your searched name is : April");
            }
            else if (month == 5)
            {
                Console.WriteLine("Your searched name is : May");
            }
            else if (month == 6)
            {
                Console.WriteLine("Your searched name is : June");
            }
            else if (month == 7)
            {
                Console.WriteLine("Your searched name is : July");
            }
            else if (month == 8)
            {
                Console.WriteLine("Your searched name is : August");
            }
            else if (month == 9)
            {
                Console.WriteLine("Your searched name is : September");
            }
            else if (month == 10)
            {
                Console.WriteLine("Your searched name is : October");
            }
            else if (month == 11)
            {
                Console.WriteLine("Your searched name is : November");
            }
            else if (month == 12)
            {
                Console.WriteLine("Your searched name is : December");
            }
            else
            {
                Console.WriteLine("Invalid month number");
            }
            return number;
        }
        /* Check a year is leap year or not using method */
        public static int yearOfBirth(int year)
        {
            int calculation = year;
            if (year % 4 == 0)
            {
                Console.WriteLine("Youre born of year is leap year");
            }
            else
            {
                Console.WriteLine("It's not leap year");
            }
            return year;
        }
    }
}
