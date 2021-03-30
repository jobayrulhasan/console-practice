using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorType1
{
    class Example
    {
        private static int counter;
        private Example() /* private constructor */
        {
            counter = 10; /* not able to access */
        }
        static Example() /* static constructor */
        {
            counter = 10;
        }
        public Example(int cout) /* public constructor */
        {
            counter = counter + cout;
        }
        public static int getIncrement()
        {
            return ++counter;
        }
        public class NestedExample 
        {
            public void test()
            {
                /* internal instance */
                Example exe = new Example();
            }
        }


    }
}
