using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefixPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prefix//
            int Number = 10;
            Console.WriteLine(Number);
            Number = ++Number;
            Console.WriteLine(Number);

            // Postfix//
            int i = 11;
            Console.WriteLine(i);
            i = i++;
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
