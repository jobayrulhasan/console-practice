using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evidance1
{
    class Program
    {
        public static int m = 0; /* global scope available */
        static void Main(string[] args)
        {
             int number; /* Declearing and using premitave data type */
            number = 10; /* Naming and assigning variable */
            Console.WriteLine(number);

            /* arithmatic operator */
            int num1 = 50;
            int num2 = 25;
            int result = (num1 + num2); /* Addition operator */
            Console.WriteLine("Addition operatior: {0}",result);
            Console.WriteLine("Subtraction operator");
            int result1 = num1 - num2; /* Subtraction operator */
            Console.WriteLine("Subtracton operator: {0}",result1);
            int result2 = num1 * num2; /* Multiplication operator */
            Console.WriteLine("Multiplication operator: {0}",result2);
            int result3 = num1 / num2; /* Divition operator */
            Console.WriteLine("Divition operator: {0}",result3);
            int result4 = num1 % num2;
            Console.WriteLine("Remainder operator: {0}",result4);
           

            /* Difference of prefix and postfix */
            /*Prefix*/
            Console.WriteLine("Difference of prefix and postfix");
            Console.WriteLine("Prefix");
            int k = 10;
            Console.WriteLine(k);
            Console.WriteLine(++k);
            Console.WriteLine(k);
            /*Postfix*/
            Console.WriteLine("postfix");
            int j = 12;
            Console.WriteLine(j);
            Console.WriteLine(j++);
            Console.WriteLine(j);

            /*Specify both named parameters*/
            AddStudent(subject: "Software", studentName: "Sala Uddin");  /* Named Arguments */
            AddStudent("Hamid", "IT");
            DoSumation(7, 5);

            Console.WriteLine(m); /*global variable can be accessible from any where in the class*/
            Console.ReadKey();


            public static int DoSumation(int number1, int number2) /*method*/
            {
                int total = number1 + number2; /*total is local scope variable*/
                Console.WriteLine("Sumation:{0}", total);
                return total;
            }

            public  static void AddStudent(string studentName, string subject = "EEE") /*here studentName is mendetory param and subject is optional parameter*/
            {
                Console.WriteLine("Student Name = {0}, Subject = {1}", studentName, subject);
            }

            Console.ReadKey();
        }
    }
}
