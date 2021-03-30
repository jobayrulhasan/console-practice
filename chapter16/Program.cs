using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 32;
            int b = 12;
            int c = 0;
            int d = 0;
            int e = 0;
          

            c = a & b;
            d = a ^ b;
            e= a | b;

            string value = Convert.ToString(c, 2); //Binary
            string value1 = Convert.ToString(d, 16); //Hexa
            string value2 = Convert.ToString(e, 8); //Oct
            Console.WriteLine("Output of AND(Binary): {0}",value);
            Console.WriteLine("Output of XOR(Hexa)  : {0}", value1);
            Console.WriteLine("Output of OR(Octa)   : {0}", value2);
            
            /*Swapping part*/
            Console.WriteLine("Enter two integers");
            int i, k;
            i = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Before swapping i= {0} and k = {1}", i, k);
            i = i ^ k;
            k = i ^ k;
            i = i ^ k;
            Console.WriteLine("\n After swapping i= {0} and k = {1}", i, k);

            Console.ReadKey();
        }
    }
}
