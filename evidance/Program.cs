using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidance
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("----ENTER INPUTS---");
                Console.Write("\nID: ");
                string id = Console.ReadLine();
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last Name: ");
                string lasttName = Console.ReadLine();
                Console.Write("Date of Birth (mm/dd/yyyy): ");
                DateTime birthDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\nDESIGNATIONS:\n-----\n1. GM\n2. DGM\n3. AGM\n4. SM\n5. Manager\n");
                Console.Write("\nInput any one serial number of the designations given above: ");
                int deg = Int32.Parse(Console.ReadLine());
                Employee anEmployee = new Employee(id, firstName, lasttName, birthDate, deg);
                Console.Write("\nGive roles of the employee (Seperate by comma[,]): ");
                string[] roles = anEmployee.GetRole(Console.ReadLine());
                Console.WriteLine("\n\nOUTPUTS\n----");
                Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.GetFullName() + "\nDate of Birth: " + anEmployee.DateOfBirth.ToShortDateString() + "\nJoining Date: " + "\nDesignation: " + anEmployee.Designation + "\nAge: " + anEmployee.getAge() + "\n\nRole plays:\n------");
                for (int i = 0; i < roles.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + roles[i].Trim());
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
