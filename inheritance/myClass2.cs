using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class myClass2:MyClassParent
   {
        public double Length { get; set; }
        public myClass2()
        {
            Length = 4;
        }
        public override double Area()
        {
            return Math.Pow(Length,2);
        }
        public override void Skip()
        {
             base.Skip();
        }
        
    }
}
