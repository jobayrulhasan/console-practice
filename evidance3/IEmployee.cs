using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidance3
{
    interface IEmployee
    {
        decimal CalculateSalary(decimal basic, decimal medical, decimal houseRent = 20, decimal conveyence = 5);
    }
}
