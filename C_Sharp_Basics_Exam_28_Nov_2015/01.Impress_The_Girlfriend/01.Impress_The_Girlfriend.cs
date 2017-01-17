using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Impress_The_Girlfriend
{
    class Program
    {
        static void Main()
        {
            var r = int.Parse(Console.ReadLine()); //rubles 100 = 3.5
            decimal russianGameValue = (r / 100) * 3.5M;
            var d = int.Parse(Console.ReadLine()); //usd 1 = 1.5
            decimal  americanGameValue = d * 1.5M;
            var e = int.Parse(Console.ReadLine()); //euros 1 = 1.95
            decimal euroGameValue = e * 1.95M;
            var b = decimal.Parse(Console.ReadLine()); //leva 2nd for 1/2
            var m = int.Parse(Console.ReadLine()); //leva 
            var mostExpensiveGame = Math.Ceiling(Math.Max(russianGameValue, Math.Max(americanGameValue, Math.Max(euroGameValue, Math.Max((b/2), m))))); //compare the prices
            Console.WriteLine("{0:f2}", mostExpensiveGame); //most expensive game
        }
    }
}
