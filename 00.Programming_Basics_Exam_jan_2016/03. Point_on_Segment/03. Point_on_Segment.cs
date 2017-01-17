/*Задача 3:
 * Точка върху отсечка
Върху хоризонтална права е разположена хоризонтална отсечка, зададена с x координатите на двата си края: first и second. Точка е разположена върху същата хоризонтална права и е зададена с x координатата си. Напишете програма, проверява дали точката е вътре или вън от отсечката и изчислява разстоянието до по-близкия край на отсечката.
Вход
От конзолата се четат 3 цели числа (по едно на ред):
•	На първия ред стои числото first – единият край на отсечката.
•	На втория ред стои числото second – другият край на отсечката.
•	На третия ред стои числото point – местоположението на точката.
Всички входни числа са цели и в диапазона [-1000…1000].
Изход
Резултатът да се отпечата на конзолата:
•	На първия ред да се отпечата “in” или “out” – дали точката е върху отсечката или извън нея.
•	На втория ред да се отпечата разстоянието от точката от най-близкия край на отсечката.*/

namespace _03.Point_on_Segment
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
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());
            int lengthToFirst = Math.Abs(first - point);
            int lengthToSecond = Math.Abs(second - point);
            if (first <= second)
            {
                if ((first <= point) && (point <= second))
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
            else if (second <= first)
            {
                if ((first >= point) && (point >= second))
                {
                Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
                Console.WriteLine(Math.Min(lengthToFirst, lengthToSecond));
        }
    }
}
