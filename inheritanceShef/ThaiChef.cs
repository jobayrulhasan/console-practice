using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceShef
{
    class ThaiChef:Chef
    {
        public override void speatialDish()
        {
            Console.WriteLine("He can makes spesial Thai food");
        }
        public void thaiMeal()
        {
            Console.WriteLine("Chicken thai soup");
        }
    }
}
