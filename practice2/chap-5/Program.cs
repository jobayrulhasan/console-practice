using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Search even number in between 0 to 100 using while loop */
            Console.WriteLine("Following result is even number list");
            int i = 0;
            while (i <= 100)
            {
                Console.WriteLine("printed result is: {0}", i);
                i = i + 2;
            }
            Console.ReadKey();

            /* Search odd number in between 0 to 100 using do wile loop */
            Console.WriteLine("Following result is odd number list");
            int j = 1;
            do
            {
                Console.WriteLine("Result is : {0}", j);
                j = j + 2;
            }
            while (j <= 100);
            Console.ReadKey();

            /* Search ten times increased number using for loop */
            Console.WriteLine("Following result is ten times increased number list");
            int k;
            for (k = 10; k <= 100; k = k + 10)
            {
                Console.WriteLine("Result is : {0}", k);
            }
            Console.ReadKey();

            /* foreach loop */
            int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            foreach (int currentNumber in number)
            {
                Console.WriteLine(currentNumber);
            }
            Console.ReadKey();

        }
    }
}
