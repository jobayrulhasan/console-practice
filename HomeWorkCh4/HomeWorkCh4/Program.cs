using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCh4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter youre garade value:)-");
            int gradeResult = Convert.ToInt32(Console.ReadLine());
             
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
                Console.WriteLine(".....The end .............");
                Console.ReadKey();    
          
        }
    }
}
