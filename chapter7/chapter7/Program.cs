using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter7
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1_7 objectName = new Class1_7(); /*instant of class*/
            Console.WriteLine("Number1:{0}\nNumber2:{1}", objectName.grade, objectName.taxt);
            Console.WriteLine(objectName);
            Console.ReadKey();
        }
    }
}
