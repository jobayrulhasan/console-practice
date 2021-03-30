using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter13
{
    class Calculator
    {
        public class calculator : Isummation, Isubtraction,Imultiplication,Idivision,Iremainder
        {
            int Isummation.sum(int value1, int value2)
            {
                return value1 + value2;
            }

            int Isubtraction.sub(int value3, int value4)
            {
                return value3 - value4;
            }

            int Imultiplication.multi(int value5, int value6)
            {
                return value5 * value6;
            }

            int Idivision.div(int value7, int valure8)
            {
                return value7 / valure8;
            }

            int Iremainder.rem(int value9, int value10)
            {
                return value9 % value10;
            }
        }
    }
}
