using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  /*Do while loop*/
            Console.WriteLine("do while loop starts here");
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 10);
            Console.WriteLine("do while loop ends here");
            #endregion


            #region /*while loop*/
            Console.WriteLine("\nwhile loop starts here");
            int a = 0;
            while (a <= 100)
            {
                Console.WriteLine(a);
                a += 10;
            }
            Console.WriteLine("while loop ends here");
            #endregion



          #region /*for loop*/
            Console.WriteLine("\nfor loop starts here");
            int k = 90;
            for (k = 2; k <= 90; k += 4)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("for loop ends here");
            Console.ReadKey();
            #endregion
        }
    }
}
