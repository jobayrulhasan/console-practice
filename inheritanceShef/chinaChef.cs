using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceShef
{
    class chinaChef:Chef
    {
        public override void speatialDish()
        {
            Console.WriteLine("He can make spesial china food");
        }
        public void chinaFood()
        {
            Console.WriteLine("China chasini from red fish");
        }
    }
}
