using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceShef
{
    class GermanChef:Chef
    {
        public override void speatialDish()
        {
            Console.WriteLine("He can make Bangladeshi and Indian BBQ dish");
        }
        public void makePasta()
        {
            Console.WriteLine("The chef makes pasta");
        }
    }
}
