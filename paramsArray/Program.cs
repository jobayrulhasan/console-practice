using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(util.Sum(10, 29, 33, 7, 6, 50));
            Console.WriteLine("");

            Console.WriteLine(util.Sum(2, 4, 6, 8));

            Console.ReadKey();
        }
    }
}
