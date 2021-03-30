using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your Number : ");
            string YourSubjectScore = Console.ReadLine();
            int YourSchore = Convert.ToInt32(YourSubjectScore);
            string result = string.Empty;
            if (YourSchore > 33)
            {
                Console.WriteLine("Congratulations! You have passed:-)");
            }
            else
                Console.WriteLine("Sorry you are failed, Please try next");

            Console.ReadKey();
        }
    }
}
