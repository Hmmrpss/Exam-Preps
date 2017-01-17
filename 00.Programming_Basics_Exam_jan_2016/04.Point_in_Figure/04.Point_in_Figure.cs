/*Задача 4:
 * Точка във фигурата
Да се напише програма, която проверява дали дадена точка (x, y) е вътре или извън следната фигура:
 
Вход
От конзолата се четат 2 цели числа (по едно на ред): x и y.
Всички входни числа са цели и в диапазона [-1000…1000].
Изход
Да се отпечата на конзолата “in” или “out” – дали точката е вътре или извън фигурата (на контура е вътре).*/

namespace _04.Point_in_Figure
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
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            bool first = (((x >= 4) && (x <= 10)) && ((y >= -5) && (y <= -3)));
            bool second = (((x >= 2) && (x <= 12)) && ((y >= -3) && (y <= 1)));
            bool third = (((x >= 4) && (x <= 10)) && ((y >= 1) && (y <= 3)));

            if (first || second || third)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
