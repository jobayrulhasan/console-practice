using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {

        public static int result = 0;
        public static int MyResult = 0;
        public static int Output = 0;

        static void Main(string[] args)
        {
            ThisMethod(20, 30, 50);
            Console.WriteLine("Your last result is: " + Output);

            MyNumber2(100,20);
           int result2 = AnotherNumber(80, 20);
            Console.WriteLine(result2);

            MyNumber(30, 20);
            Console.WriteLine(result);

            Console.ReadKey();
        }
         static void MyNumber(int num1, int num2)
        {
            int sum =  num1 + num2;
            result = sum;
            Console.WriteLine("{0} + {1}", num1, num2);
        }
        static int  AnotherNumber(int fristNumber , int secondNumber)
        {
            return fristNumber + secondNumber;
        }
        static void MyNumber2(int NumberOne , int NumberTwo)
        {
            int sub = NumberOne - NumberTwo;
            MyResult  = sub;
            Console.WriteLine(MyResult);
        }
        static void ThisMethod (int a, int b, int c)
        {
            int calculation = a + b + c;
            Output = calculation;
        }
    }
}
