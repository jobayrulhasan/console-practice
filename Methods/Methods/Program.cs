using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non return data type method
            PrintFullName("Jobayrul", "Hasan");
            // int data type methods
            int result = Clculation(100, 33);
            Console.WriteLine("Your calculated result is : {0}", result);
            // string data type method.
            Console.WriteLine("Your name is : "+ FullName("Aminul","Islam"));

            Console.ReadKey();
        }
        public static void PrintFullName(string FirstName , string LastName)
        {
            Console.WriteLine("Your name is : {0} {1}", FirstName, LastName);
           
        }
        public static int Clculation(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public static string FullName(string FristName, string LastName)
        {
            string Name = FristName +" "+LastName;
            return Name;
        }
    }
}
