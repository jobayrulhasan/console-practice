using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEvidence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INPUTS\n================================");
            Console.Write("\nEmployee ID: ");
            string ID = Console.ReadLine();

            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Date of Birth: ");
            string dateOfBirth = Console.ReadLine();

            Console.Write("Designation { CEO = 1, Programmer = 2, Designer = 3 }");
            string Designation = Console.ReadLine();

            Console.Write("Basic Salary: ");
            string Basic = Console.ReadLine();

            Console.Write("Medical(%): ");
            string Medical = Console.ReadLine();

            Console.Write("Overtime: ");
            string overtime = Console.ReadLine();

            Employee em = new Employee();
            em.ID = Convert.ToInt32(ID);

            em.Name = Name;

            em.DateOfBirth = Convert.ToDateTime(dateOfBirth);

            em.GetDesignation = (Designation)Convert.ToInt32(Designation);

            em.Basic = Convert.ToDecimal(Basic);

            em.Medical = Convert.ToDecimal(Medical);

            em.overtime = Convert.ToDecimal(overtime);

            em.GrossPay = em.CalculateSalary(em.Basic, em.Medical, em.overtime);

            string role = "";

            while (role.ToUpper() != "A")
            {
                Console.WriteLine("Role: [A to stop]");
                role = Console.ReadLine();

                if (role.ToUpper() != "A")
                {
                    em.AddRole(role);
                }
            }

            Console.WriteLine("\n\nOUTPUTS\n================================");

            Console.WriteLine($"ID\t\t: {em.ID}");

            Console.WriteLine($"Name\t\t: {em.Name}");

            Console.WriteLine($"Date of Birth\t: {em.DateOfBirth.ToShortDateString()}");

            Console.WriteLine($"Designation\t: {em.GetDesignation}");

            Console.WriteLine($"Role Plays\t: {em.RolePlay()}");

            Console.WriteLine($"Over Time\t: {em.overtime}");

            Console.WriteLine($"Gross Pay\t: {em.GrossPay}");

           
            Console.ReadKey();
        }
    }
}
