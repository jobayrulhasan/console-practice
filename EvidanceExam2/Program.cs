using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceExam2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter employee ID : ");
            string ID = Console.ReadLine();
            Console.Write("Enter your employee name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter your date of birth : ");
            string dateOfBirth = Console.ReadLine();
            Console.Write("Enter designation(Programmer = 1,Manager = 2,Marketing_officer = 3,Area_manager = 4,Doctor = 5,Electrical_Engineer = 6,Civil_Engineer = 7)-");
            string designation = Console.ReadLine();
            Console.Write("Enter Basic salary : ");
            string Basic = Console.ReadLine();
            Console.Write("Enter medical allowance % : ");
            string Medical = Console.ReadLine();
            Console.Write("Enter house allowance % : ");
            string houseRnt = Console.ReadLine();
            Employee employee = new Employee();
            employee.ID = Convert.ToInt32(ID);
            employee.Name = Name;
            employee.DoB = Convert.ToDateTime(dateOfBirth);
            employee.designation = (Designations)Convert.ToInt32(designation);
            employee.Basic = Convert.ToDecimal(Basic);
            employee.Medical = Convert.ToDecimal(Medical);
            employee.GrossPay = employee.calculateSalary(employee.Basic,employee.Medical, employee.HouseRent,employee.Conveyence);
            string rol = "";
            while (rol.ToUpper() != "A")
            {
                Console.WriteLine("Role:[A to stop]");
                rol = Console.ReadLine();
                if (rol.ToUpper() != "A")
                {
                    employee.AddRole(rol);
                }
            }
            Console.WriteLine("-----------------");
            Console.WriteLine($"Enter employee ID : {employee.ID}");
            Console.WriteLine($"Enter your employee name : {employee.Name}");
            Console.WriteLine($"Enter your date of birth : {employee.DoB.ToShortDateString()}");
            Console.WriteLine($"Designation : {employee.designation}");
            Console.WriteLine($"Gross pay : {employee.GrossPay}");
            Console.WriteLine($"Role plays : {employee.RolePlay()}");
            Console.WriteLine("-----------------");
            Console.ReadKey();
        }
    }
}
