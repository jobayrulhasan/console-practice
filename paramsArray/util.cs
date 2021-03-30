using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsArray
{
    class util
    {

        public static int Sum(params int[] ParamList)
        {
            Console.WriteLine("Using Parameter List");

            if (ParamList == null)
            {
                throw new ArgumentException("Util.Sum: Null Parameter List");
            }
            if (ParamList.Length == 0)
            {
                throw new ArgumentException("Util.Sum: Empty Parameter List");
            }

            int sumTotal = 0;

            foreach (int i in ParamList)
            {
                sumTotal += i;
            }

            return sumTotal;
        }

        public static int Sum(int param1 = 0, int param2 = 0, int param3 = 0, int param4 = 0)
        {
            Console.WriteLine("Using Optional Parameter");

            int sumTotal = param1 + param2 + param3 + param4;

            return sumTotal;
        }
    }
}
