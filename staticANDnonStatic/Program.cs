using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticANDnonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*application of instance class member.It's possible for multipole times*/
            Circle cr = new Circle(14);
            cr.getResult();
            Circle cr1 = new Circle(16);
            cr1.getResult();
            Circle cr2 = new Circle(18);
            cr2.getResult();
            Circle cr3 = new Circle(20);
            cr3.getResult();
           /*application of static calss member.It's not possible for multiple times call.It's use for single time.*/
            Console.WriteLine("\n\nOutput of Pi is : {0}",Circle.pi);
            Console.ReadKey();
        }   
    }
}
