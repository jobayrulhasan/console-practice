using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class Car:Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerate");
        }
        public void Break()
        {
            Console.WriteLine("Breaking");
        }
    }
}
