/*Задача 2:
 * Пренасяне на тухли
Строителни работници трябва да пренесат общо x тухли. Работниците са w на брой и работят едновременно. Те превозват тухлите в колички, всяка с вместимост m тухли. Напишете програма, която прочита целите числа x, w и m и пресмята колко най-малко курса трябва да направят работниците за да превозят тухлите.
Вход
От конзолата се четат 3 цели числа (по едно на ред):
•	Броят тухли x се чете от първия ред.
•	Броят работници w се чете от втория ред.
•	Вместимостта на количката m се чете от третия ред.
Всички входни числа са цели и в диапазона [1…1000].
Изход
Да се отпечата на конзолата минималният брой курсове, необходими за превозване на тухлите.*/

namespace _02.Bricks
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
            double x = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double bricksPerRound = w * m; //may be skipped
            double rounds = x / bricksPerRound;
            Console.WriteLine("{0}", Math.Ceiling(rounds));
        }
    }
}
