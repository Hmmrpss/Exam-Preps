using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sudoku_Results
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine(); ;            
            int games = 0;
            int time = 0;
            while (input != "Quit")
	        {
                input = Console.ReadLine();
                int minutes = int.Parse(input.Substring(0, 2));
                int seconds = int.Parse(input.Substring(3, 2));
                time = ((minutes * 60) + seconds) ;
                games++;
            }
            double averageTime = time / 2;
            if (averageTime < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if ((720 <= averageTime) && (averageTime <= 1400))
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine("Games – {0} \\ Average seconds – {1}", games, Math.Ceiling(averageTime));
        }
    }
}
