using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Journey by airplane:");
            Airplane myplane = new Airplane();
            myplane.startEngine("contact");
            myplane.takeOff();
            myplane.Drive();
            myplane.Land();
            myplane.stopEngine("Whirr");

            Console.WriteLine("\nJourney by car:");
            Car myCar = new Car();
            myCar.startEngine("Brm brm");
            myCar.Accelerate();
            myCar.Drive();
            myCar.Break();
            myCar.stopEngine("Phut phut");
            Console.ReadKey();
        }
    }
}
