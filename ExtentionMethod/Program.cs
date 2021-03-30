using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arrange the numbers in serial:)- ");
            int[] myNumber = { 12, 78, 56, 36, 22, 91, 73, 44, 23, 21, 29, 53, 52 };
            var outCome = myNumber.OrderBy(m => m);
            foreach (int items in outCome)
            {
                Console.Write(items + " ");
            }
            /*using enum in array*/
            Console.WriteLine("\nPrint the months by name:)-");
            string[] moths = Enum.GetNames(typeof(Month));
            foreach (string i in moths)
            {
                Console.WriteLine("Name of the months:{0}",i);
            }
            Console.WriteLine("\nPrint the months by number:)-");
            int [] month =(int[]) Enum.GetValues(typeof(Month));
            foreach (int  j in month)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
        public enum Month
        {
            January=1,
            February=2,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
