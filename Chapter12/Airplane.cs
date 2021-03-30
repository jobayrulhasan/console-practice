using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class Airplane:Vehicle
    {
        public void takeOff()
        {
            Console.WriteLine("Taking off");
        }
        public void Land()
        {
            Console.WriteLine("Landing");
        }
    }
}
