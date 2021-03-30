using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            CiyName ct = CiyName.Chittagong;
            Console.WriteLine("This is the city of: {0}",ct);
            Console.ReadKey();
        }
        public enum CiyName
        {
            Dhaka,
            Chittagong,
            Khulna,
            Tangail
        }
    }
}
