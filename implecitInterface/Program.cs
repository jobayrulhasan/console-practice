using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implecitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Enum.GetNames(typeof(WeekDay));
            foreach (string wd in names)
            {
                Console.WriteLine(wd);
            }
            Console.WriteLine();

            int[] days = (int[])Enum.GetValues(typeof(WeekDay));
            foreach (int d in days)
            {
                Console.WriteLine(d);
            }


            Console.ReadLine();
        }
        public enum WeekDay
        {
            Saturday = 1, Sunday = 2, Monday, Tuesday, Wednesday, Thursday, Friday
        }
    }
    
}
