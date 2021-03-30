using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seasons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your favourite season name:)-");
            string month = Console.ReadLine();
            switch (month)
            {
                case "summar":
                    Console.WriteLine("It's hot season");
                    break;
                case "rainy":
                    Console.WriteLine("Huge rain over the country and duration is about 4 months");
                    break;
                case "autum":
                    Console.WriteLine("Less hot and less rain season");
                    break;
                case "late autum":
                    Console.WriteLine("This is the season of Nobanno,means new rice harvesting.");
                    break;
                case "winter":
                    Console.WriteLine("Cold air flow over the country during this season");
                    break;
                case "spring":
                    Console.WriteLine("This is the season of cuckoo singing");
                    break;
                default:
                    Console.WriteLine("Not maching season name");
                    break;
            }
            Console.ReadKey();
               
        }
    }
}
