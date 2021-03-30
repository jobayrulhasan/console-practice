using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piCalculation
{
    class Circle
    {
        int radius;

        public Circle() /*default constructor*/
        {
            radius = 10;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }

    }
}
