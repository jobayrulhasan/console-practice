using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace answerB
{
    class Program
    {
        public static int m = 30;    /*global variable declear*/
        static void Main(string[] args)
        {
            #region  /* Declaring and namimg variables */
            Console.Write("Declaring and assigning variable:)");
            int num;
            num = 20;
            Console.WriteLine(num);
            #endregion


            #region  /* arithmatic operator is following */
            Console.WriteLine("\nArithmatic operation is following");
            int number1 = 100;
            int number2 = 20;
            /* Multiplication operator */
            int multiResult = (number1 * number2);
            Console.WriteLine("Multiplication result is : {0}", multiResult);
            /* Division operator */
            int divResult = (number1 / number2);
            Console.WriteLine("Division result is : {0}", divResult);
            /* Remainder operator */
            int reminResult = (number1 % number2);
            Console.WriteLine("Remainder result is : {0}", reminResult);
            /* Addition operator */
            int addResult = (number1 + number2);
            Console.WriteLine("Addition result is : {0}", addResult);
            /* Subtructio operator */
            int subResult = (number1 - number2);
            Console.WriteLine("Subtruction result is : {0}\n", subResult);

            /*Specify both named parameters*/
            AddStudent(subjectName: "Software", studentName: "Sala Uddin");  /* Named Arguments */
            AddStudent("Hamid", "IT\n");
            AddStudent("Sohel Rana","History And Culture\n");
            AddStudent("Amir Hossain");
            DoSumation(10, 20);

            Console.WriteLine("Result came from global variable: {0}", m); /*global variable can be accessible from any where in the class*/

            /* Difference of prefix and postfix */
            Console.WriteLine("Difference of prefix and postfix");
            #region      /*Prefix*/
            Console.WriteLine("\nPrefix");
            int count = 20;
            Console.WriteLine(count);
            Console.WriteLine("Result during prefix: {0}", ++count);
            Console.WriteLine("Result after prefix: {0}\n", count);
            #endregion


            #region  /*Postfix*/
            Console.WriteLine("Postfix");
            int count1 = 30;
            Console.WriteLine(count1);
            Console.WriteLine("Result during postfix: {0}", count1++);
            Console.WriteLine("Result after postfix: {0}", count1);
            Console.ReadKey();
            #endregion

            Console.ReadKey();
        }
        #endregion

        #region /* Method declaration */
        public static int DoSumation(int num1, int num2) /*method*/
        {
            int total = (num1 + num2); /*total is local scope variable*/
            Console.WriteLine("\nSumation:{0}\n", total);
            return total;
        }
        public static void AddStudent(string studentName, string subjectName = "EEE") /*here studentName is mendetory param and subject is optional parameter*/
        {
            Console.WriteLine("Student Name : {0}\nSubject : {1}", studentName, subjectName);
        }
        #endregion
    }
}
