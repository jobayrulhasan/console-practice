using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            NameOfBaby("Jobayeul Hasan", 23);
            schoolName("Sagoria High School\n");
            NameOfBaby("Amirul Islam", 22);
            schoolName("Sagoria High School\n");
            NameOfBaby("Sharif Uddin", 25);
            schoolName("Sagoria High School\n");
            NameOfBaby("Bahar Uddin", 28);
            schoolName("Sagoria High School");
            Console.ReadKey();
        }
        public static void NameOfBaby(string name, int age)
        {
            Console.WriteLine(name + " "  +" " + "is" +" " + age);
        }
        public static void schoolName(string scName)
        {
            Console.WriteLine("His school name is: {0}", scName);
        }
    }
}
