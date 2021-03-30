using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidance
{
   public sealed class Employee:Person,IRole
    {
        public string  ID { get; set; }
        public override string FirstName { get => firstName; set => firstName=value; }
        public override string LastName { get => lastName; set => lastName=value; }
        public override DateTime DateOfBirth { get => birthDate; set => birthDate = value; }
        public string Designation { get; set; }


        public Employee(string id, string firstName, string lastName, DateTime birthdate, int desg)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = birthdate;
            this.Designation = Enum.GetName(typeof(Designation), desg);
        }
        public override string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public override string getAge()
        {
            TimeSpan age = DateTime.Now - DateOfBirth;
            int years = age.Days / 365;
            int months = (age.Days - years * 365) / 30;
            int days = (age.Days - years * 365 - months * 30);
            return years.ToString() + " years " + months.ToString() + " months " + days.ToString() + " days.";
        }
        public string[] GetRole(string role)
        {
            string[] roles = role.Split(',');
            return roles;
        }
    }
}
