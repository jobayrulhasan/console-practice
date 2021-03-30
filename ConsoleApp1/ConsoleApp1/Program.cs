using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char cha = 'V';
            int kaa = Convert.ToInt32(cha);
            Console.WriteLine("Your printed ASCII code is : {0}",kaa);

            Console.WriteLine("Minimum value of long is:{0}\nMaxmimum value of long is:{1}", long.MinValue, long.MaxValue);
            Console.ReadKey();
        }
    }
}

