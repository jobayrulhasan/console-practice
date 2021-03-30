using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee name = new Employee();
            Console.WriteLine(name.getexp());
            name.hisSalary = 3000;
            Console.WriteLine(name.hisSalary);
            Console.ReadKey();
        }
    }
}
