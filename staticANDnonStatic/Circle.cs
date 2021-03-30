using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticANDnonStatic
{
    class Circle
    {
        public static float pi;  /*This is the static member of class */
        int Radious; /*This is the instance member of class */

        static Circle() /*This is static constructor!.Static constructor does not allow prarameter*/
        {
            pi = 3.1416f; /*static constructor's value assigned.*/
        }

        public Circle(int radious) /* parameterized constructor. instance constructor allow parameter */
        {
            this.Radious = radious;
        }

        public void getResult()
        {
            Console.WriteLine("Calculated result of radious is: {0}", pi * Radious * Radious);
        }
    }
}
