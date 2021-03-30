using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClassParent myClass1 = new myClass1();
            Console.WriteLine("Area is : {0}",myClass1.Area());
            MyClassParent myClass2 = new myClass2();
            Console.WriteLine("Area is: {0}",myClass2.Area());
            MyClassParent myClass3 = new myClass3();
            Console.WriteLine("Area is: {0}",myClass3.Area());
            Console.ReadKey();
        }
    }
}
