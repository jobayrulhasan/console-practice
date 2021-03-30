using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            while (a >= 2)
            {
                Console.WriteLine(a);
                a--;
            }
            

            //do
            //{
            //    Console.WriteLine("Your printed value is :) {0}",x);
            //    x = x - 5;
            //}
            //while (x >= 5);

            Console.ReadKey();

        }
    }
}
