using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = Enum.GetNames(typeof(NameOfMonth));
            foreach (string Myitem in nameList)
            {
                Console.WriteLine("This is the month of: {0}",Myitem);
            }

            int[] numMonth = (int[])Enum.GetValues(typeof(NameOfMonth));
            foreach (int month in numMonth)
            {
                Console.WriteLine("Month position is: {0}", month);
            }
            Console.ReadKey();
        }
        public enum NameOfMonth
        {
            January=1,
            February=2,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }
}
