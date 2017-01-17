using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Prospect_In_Hospitality
{
    class Program
    {
        static void Main()
        {
            int b = int.Parse(Console.ReadLine()); //builders
            int r = int.Parse(Console.ReadLine()); //receptionists 
            int c = int.Parse(Console.ReadLine()); //chambermaids
            int t = int.Parse(Console.ReadLine()); //technicians
            int o = int.Parse(Console.ReadLine()); //others
            float n = float.Parse(Console.ReadLine()); //Niki the lawer
            float u = float.Parse(Console.ReadLine()); //currency rate  D
            float s = float.Parse(Console.ReadLine()); //my salary      D
            float m = float.Parse(Console.ReadLine()); //budget         D
            var moneyNeeded = (b * 1500.04) + (r * 2102.10) + (c * 1465.46) + (t * 2053.33) + (o * 3010.98) + (n * u) + s;
            bool enoughMoney = (moneyNeeded == m);

            Console.WriteLine("The amount is: {0:f2} lv.", moneyNeeded);
            if (enoughMoney)
            {
                Console.WriteLine("YES \\ Left: {0:f2} lv.", m - moneyNeeded);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:f2} lv.", Math.Abs(m - moneyNeeded));
            }
        }
    }
}
