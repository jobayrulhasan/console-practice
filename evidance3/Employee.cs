using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidance3
{
   public sealed class Employee:Person
    {
        public int ID { get; set; }
        public Designations Designation { get; set; }
        public decimal Basic { get; set; }
        public decimal Medical { get; set; }
        public decimal HouseRent { get; set; }
        public decimal Conveyence { get; set; }
        public decimal GrossPay { get; set; }
        public string[] RolePlays { get; set; }
        public decimal CalculateSalary(decimal basic, decimal medical, decimal houseRent = 20, decimal conveyence = 5)
        {
            decimal grossPay = basic
                + (basic * (medical / 100))
                + (basic * (houseRent / 100))
                + (basic * (conveyence / 100));
            return grossPay;
   }    }
}
