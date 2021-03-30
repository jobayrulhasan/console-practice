using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidanceExam2
{
    interface IEmployee
    {
        decimal calculateSalary(decimal basic, decimal medical,decimal houseRent = 5, decimal conveyence = 20);
    }
}
