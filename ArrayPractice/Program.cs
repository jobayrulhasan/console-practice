using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers = { 15, 88, 76, 99, 55, 23, 46, 33 };
           
            Console.WriteLine("This is the maximum number of Array: {0}",myNumbers.Max());
            Console.WriteLine("This is the minimum number of Array: {0}",myNumbers.Min());
            Console.WriteLine("This is the summation of the Array: {0}",myNumbers.Sum());

            Console.WriteLine("\nThis is the output of Array list");
            foreach (int item in myNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("...This is the output of rearrange of array list");
            var result = myNumbers.OrderBy(k => k);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nThis is the output for string type data");
            string[] carName = { "Tata", "BMW", "Toyota", "Mitshubishi", "Tesla", "Volvo" };
            foreach (string item in carName)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
