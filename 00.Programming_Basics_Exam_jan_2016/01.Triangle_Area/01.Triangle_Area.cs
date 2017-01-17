/*Задача 1:
 * Лице на триъгълник в равнината
Триъгълник в равнината е зададен чрез координатите на трите си върха. Първо е зададен върхът (x1, y1). След това са зададени останалите два върха: (x2, y2) и (x3, y3), които лежат на обща хоризонтална права (т.е. имат еднакви Y координати). Напишете програма, която пресмята лицето на триъгълника по координатите на трите му върха.
Вход
От конзолата се четат 6 цели числа (по едно на ред):
x1, y1, x2, y2, x3, y3.
•	Всички входни числа са в диапазона [-1000…1000].
•	Гарантирано е, че y2 = y3.
Изход
Лицето на триъгълника да се отпечата на конзолата.*/

namespace _01.Triangle_Area
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double a = Math.Abs(x3 - x2);
            double h = Math.Abs(y2 - y1);
            double area = (a * h) / 2;
            Console.WriteLine("{0}", area);
        }
    }
}
