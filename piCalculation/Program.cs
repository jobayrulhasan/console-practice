using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myCircule = new Circle();
            double result = myCircule.Area();
            Console.WriteLine("Area of a circle is:{0}",result);

            Console.ReadKey();
        }
    }
}
