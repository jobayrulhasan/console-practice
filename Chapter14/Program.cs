using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    public class Garbage
    {
        public Garbage()
        {
            Console.WriteLine("Reveiver memory");
        }
        ~Garbage()
        {
            Console.WriteLine("Free memory");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Garbage ge = new Garbage();
            ge = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
