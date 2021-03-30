using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationAndAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.ID = 33;
            st.name = "Sharif Uddin";
            Console.WriteLine("Student ID: {0}",st.ID);
            Console.WriteLine("Student Name: {0}",st.name);
            Console.ReadKey();
        }
    }
}
