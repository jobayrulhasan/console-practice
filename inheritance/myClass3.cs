using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class myClass3:MyClassParent
   {
        public double radius { get; set; }
        public myClass3()
        {
            radius = 12;
        }
        public override double Area()
        {
            return (3.14) * Math.Pow(radius,2);
        }
        public sealed override double Ayaton()
        {
            return 0;
        }
    }
}
