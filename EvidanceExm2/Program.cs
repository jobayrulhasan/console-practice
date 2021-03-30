using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceExm2
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("choose vehicle from below by number \n");
          Console.Write("Press'4'for Car'or Press'2' for Motorcycle)-");

            /*It's car information portion*/
            int vehicleType = int.Parse(Console.ReadLine());
            Car car = new Car();
            Console.Write("Enter car's engine CC: ");
            car.EngineCapacityCC = int.Parse(Console.ReadLine());
            Console.Write("Enter Model Number: ");
            car.ModelNo = Console.ReadLine();
            Console.Write("Enter year manufacturing: ");
            car.YearMake = int.Parse(Console.ReadLine());
            Console.Write("Enter number of gear:");
            car.NumberOfGear = int.Parse(Console.ReadLine());
            Console.Write("Enter number of door: ");
            car.NumberOfDoor = int.Parse(Console.ReadLine());
            IInterior iinterior = new FourWheeler();
            iinterior.DesignInterior(car);
           
            /*It's motorcycle information portion*/
            Motorcycle motorCycle = new Motorcycle();
            Console.Write("Enter motorcyle's engine CC: ");
            motorCycle.EngineCapacityCC = int.Parse(Console.ReadLine());
            Console.Write("Enter milage of montorcyle: ");
            motorCycle.MilagePowerNM = decimal.Parse(Console.ReadLine());
            Console.Write("Enter model number: ");
            motorCycle.ModelNo = Console.ReadLine();
            Console.Write("input Front Break: ");
            motorCycle.FrontBreak = Console.ReadLine();
            Console.Write("input Rear Break: ");
            motorCycle.RearBreak = Console.ReadLine();
            Console.Write("input Year: ");
            motorCycle.YearMake = int.Parse(Console.ReadLine());
            IExterior iExterior = new TwoWheeler();
            iExterior.DesignExterior(motorCycle);
            Console.ReadLine();
        }
    }
}
