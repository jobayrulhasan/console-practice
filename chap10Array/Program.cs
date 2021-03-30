using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNumber = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; /*create an array with integer data type*/
            Console.WriteLine(myNumber[7]);
            string[] cityName = { "Dhaka", "Singapore city", "Toronto", "Helsinki", "Barlin", "Oslo","Moscow" }; /*create an array with string data type*/
            Console.WriteLine(cityName[6]);

            string[] newArray = new string[4];
            newArray[0] = "Array0";
            newArray[1] = "Array1";
            newArray[2] = "Array2";
            newArray[3] = "Array3";

            Console.WriteLine(newArray[3]);
            showArray(newArray);
            Console.ReadKey();
        }
        static void showArray(string[] getArray)
        {
            foreach (string display in getArray)
            {
                Console.WriteLine(display);
            }
        }
    }
}
