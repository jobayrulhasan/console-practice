using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEvidence
{
    interface IEmployee
    {
        decimal CalculateSalary (
        decimal basic, 
        decimal medical,
        decimal overtime,
        decimal hourseRent = 20,
        decimal conveyence = 5);
    }
}
