using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            bc.myMethod();
            bc.myOtherMethod();
            bc.myAnotherMethod();
            bc.MyforthInterface();
            Console.ReadKey();
        }
    }
}
