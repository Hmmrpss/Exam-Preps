using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Magic_Car_Numbers
{
    class Program
    {
        static void Main()
        {
            int magicWeight = int.Parse(Console.ReadLine()); // given value
            int specialMagicWeight = 40;
            char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            char letter;
            int numbers;
           //int number;
            
            for (int i = 0; i < 4; i++)
			{
                for (int number = 0; number < 10; number++)
			    {
			        
			    }
			}
            switch (numbers)
            {
                case 'aaaa':
                    break;
                case 'abbb':
                    break;
                case 'aaab':
                    break;
                case 'aabb':
                    break;
                case 'abab':
                    break;
                case 'abba':
                    break;
            }
            switch (letter)
            {
                case 'A':
                    specialMagicWeight += 10;
                    break;
                case 'B':
                    specialMagicWeight += 20;
                    break;
                case 'C':
                    specialMagicWeight += 30;
                    break;
                case 'E':
                    specialMagicWeight += 50;
                    break;
                case 'H':
                    specialMagicWeight += 80;
                    break;
                case 'K':
                    specialMagicWeight += 110;
                    break;
                case 'M':
                    specialMagicWeight += 130;
                    break;
                case 'P':
                    specialMagicWeight += 160;
                    break;
                case 'T':
                    specialMagicWeight += 200;
                    break;
                case 'X':
                    specialMagicWeight += 240;
                    break;
            }

        }
    }
}
