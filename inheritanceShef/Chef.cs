using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceShef
{
    class Chef
    {
        public void MakeChiken()
        {
            Console.WriteLine("This shef able to made chiken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("He can made salad");
        }
        public void MakeTikka()
        {
            Console.WriteLine("He is able to make tikka");
        }
        public virtual void speatialDish()
        {
            Console.WriteLine("He can make Bangladeshi BBQ dish");
        }
    }
}
