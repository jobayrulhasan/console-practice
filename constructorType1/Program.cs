using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorType1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This portion is for default constructor*/
            defaultConstructor conDef = new defaultConstructor(); 
            Console.WriteLine("Student ID: {0}",conDef.studentID);
            Console.WriteLine("Student name: {0}",conDef.StudentName);
            Console.WriteLine("Address: {0}",conDef.Address);
            /*Ends default constructor area*/

            /*Parameterized Constructor starts here*/
            prameterizedConstructor pc = new prameterizedConstructor(99,"Hamidur Rahman","Dhaka,Bangladesh");
            Console.WriteLine("\nStudent ID: {0}", pc.studentID);
            Console.WriteLine("Student name: {0}", pc.StudentName);
            Console.WriteLine("Address: {0}", pc.Address);
            /*Parameterized Constructor ends here*/



            /* static and private access modifier starts here*/
            // external instance
            // Example ex = now Example();

            Example ex = new Example(10);
            Console.WriteLine("\n\nCounter: {0}",Example.getIncrement());
            /* static and private access modifier ends here*/
            Console.ReadKey();
        }
    }
}
