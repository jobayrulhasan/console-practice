using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
   public class myClass1:MyClassParent
   {
        public double Height { get; set; }
        public double Width { get; set; }
        public myClass1()
        {
            Height = 20.3;
            Width = 11.4;
        }
        public override double Area()
        {
            return Height * Width;
        }
    }
}
