using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreAndPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Difference of prefix and postfix */
            Console.WriteLine("Difference of prefix and postfix");
            #region      /*Prefix*/
            Console.WriteLine("\nPrefix");
            int count = 20;
            Console.WriteLine(count);
            Console.WriteLine("Result during prefix: {0}",++count);
            Console.WriteLine("Result after prefix: {0}\n",count);
            #endregion


            #region  /*Postfix*/
            Console.WriteLine("Postfix");
            int count1 = 30;
            Console.WriteLine(count1);
            Console.WriteLine("Result during postfix: {0}",count1++);
            Console.WriteLine("Result after postfix: {0}", count1);
            Console.ReadKey();
            #endregion
        }
    }
}
