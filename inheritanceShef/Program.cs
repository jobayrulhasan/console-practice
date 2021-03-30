using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceShef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the output of Chef");
            Chef bdShef = new Chef();
            bdShef.MakeChiken(); //extension method
            bdShef.MakeSalad();
            bdShef.MakeTikka();
            bdShef.speatialDish();
            Console.WriteLine("\nThis is the output of Germany chef");
            GermanChef ger = new GermanChef();
            ger.MakeChiken();
            ger.MakeSalad();
            ger.MakeTikka();
            ger.makePasta();
            ger.speatialDish();
            Console.WriteLine("\nThis is the output of China chef");
            chinaChef ch = new chinaChef();
            ch.MakeChiken();
            ch.MakeSalad();
            ch.MakeTikka();
            ch.chinaFood();
            ch.speatialDish();
            Console.WriteLine("\nThis is the output of Thai chef");
            ThaiChef tc = new ThaiChef();
            tc.MakeChiken();
            tc.MakeSalad();
            tc.MakeTikka();
            tc.thaiMeal();
            tc.speatialDish();

            Console.ReadKey();
        }
    }
}
