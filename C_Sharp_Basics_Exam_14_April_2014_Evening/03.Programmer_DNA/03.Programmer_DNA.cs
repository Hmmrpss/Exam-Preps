using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03.Programmer_DNA
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());  //length
            int numberOfBlocks = n / 7;
            int rowsLeft = n % 7;
            string c = Console.ReadLine();
            string [] letters = {"A", "B", "C", "D", "E", "F", "G"}; // index 0 to 6
            //bool incrreasing = (n % 10 < 5); // tuk trqbva a e row a ne n
            //bool decrreasing = (n % 10 > 5);
            for (int block = 0; block < numberOfBlocks; block++) // otpechatva vsichki celi blokove 
			{
                for (int row = 0; row < 7; row++)
			    {
                    if (row <= 4)
	                {
		            Console.Write(" ", (3 - row));
                    Console.Write(letters[], ((2 * row) + 1));  // the index of the char
                    Console.Write(" ", (3 - row));
                    Console.WriteLine();
	                }
               }  
            } 

        }
    }
}
