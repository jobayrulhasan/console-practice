using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    /*implement MyInterface(this is the interface name) interface*/
    class BaseClass : IInterfaceOne, IInterfaceTwo, IInterfaceThree, IInterfaceFour
    {
        public void myMethod()
        {
            // The body of myMethod() is provided here
            Console.WriteLine("This is the method one");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("This is the second method");
        }
        public void myAnotherMethod()
        {
            Console.WriteLine("This is the third method");
        }
        public void MyforthInterface()
        {
            Console.WriteLine("This is the forth method");
        }
    }
}
