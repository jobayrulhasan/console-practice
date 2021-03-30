using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    class Until
    {
        public static int sum(params int [] paramList)
        {
            int sumTotal = 0;
            foreach (int  i in paramList)
            {
                sumTotal += 1;

            }
            return sumTotal;
        }
        public static int sum(int param1 = 0, int  param2= 0, int param3= 0)
        {
            int sumTotal = param1 + param2 + param3;
            return sumTotal;
        }
    }
}
