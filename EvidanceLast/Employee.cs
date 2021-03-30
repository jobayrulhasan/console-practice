using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceLast
{
    class Employee:Person,IRole
    {
        public string ID { get; set; }
        public override string FirstName { get => firstName; set => firstName = value; }
        public override string LastName { get => lastName; set => lastName = value; }
        public override DateTime BirthDate { get => DateOfBirth; set => DateOfBirth = value; }
    }
    public  DateTime JoiningDate { get; set; }
    public string Designation { get; set; }
    public Employee(string id, string fristName,string lastName,DateTime BrithDate, DateTime JoiningDate,int Designation)
    {
        this.ID = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.BirthDate = birthDate;
        this.JoiningDate = JoiningDate;
        this.Designation = Enum.GetName(typeof(Designation), desig);
    }
    public override string GetAge()
    {
        TimeSpan age = DateTime.Now - BirthDate;
        int years = age.Days / 365;
        int months = (age.Days - years * 365) / 30;
        int days = (age.Days - years * 365 - months * 30);
        return years.ToString() + " years " + months.ToString() + " months " + days.ToString() + " days.";
    }

    public override string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    public string[] GetRole(string role)
    {
        string[] roles = role.Split(',');
        return roles;
    }

}
