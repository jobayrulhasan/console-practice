using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7Ref
{
    class Program
    {
        static void Main(string[] args)
        {

            int salary = 3000;
            myRef(ref salary);
            Console.WriteLine(salary);
            int tax;
            myTax(out tax);
            Console.WriteLine(tax);
  
            Console.ReadKey();
        }
        static void myRef(ref int salary)
        {
            int bonus = 1000;
            salary = bonus + salary; 
        }
        static void myTax(out int tax) /* out is value type */
        {
             tax = 200;
        }
    }
}
