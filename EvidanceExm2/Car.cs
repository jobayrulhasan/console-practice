using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceExm2
{
    class Car:FourWheeler
    {
        public Car()
        {
            vehicleTypes = VehicleType.FourWheeler;
            NumberOfSeat = 5;
        }
    }
}
