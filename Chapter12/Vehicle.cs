using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class Vehicle
    {
        public void startEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine($"Starting engine: ");
        }
        public void stopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine($"Sotp engine: ");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Default implementaion of the drive method");
        }
    }
}
