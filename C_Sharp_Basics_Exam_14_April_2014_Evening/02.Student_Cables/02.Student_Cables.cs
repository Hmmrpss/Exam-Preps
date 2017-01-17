using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Student_Cables
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine()); // broq na kabelite, koito poluchavash na vhoda
            int cableLength; //duljina na podavaniq kabel
            string cableMeasure; // tip na mernata edinica
            int numberOfInvalidCables; //broq na kabeli pod 20cm
            int validCablePieces; // za vsichki validni parcheta kabel
            int joinedCableLength; // obshtata duljina na kabela
            int numberOfStudentCables; // broq na kabelite, koito mojem da napravim
            int remainder; // ostatuka

            for (int i = 0; i < n; i++) // chetesh informaciqta i proverqvash dali e validna
            {
                cableLength = int.Parse(Console.ReadLine());
                cableMeasure = Console.ReadLine();
                if (((cableMeasure == "centimeters") && (cableLength > 20)) || ((cableMeasure == "meters"))) //ako e validen
                {
                    if (cableMeasure == "meters")
                    {
                        validCablePieces += (cableLength * 100);
                    }
                    else
                    {
                        validCablePieces += cableLength;
                    }
                    
                    
                }
                else
                {
                    numberOfInvalidCables++;
                    continue;
                }
            }
            joinedCableLength = validCablePieces - (3 * (n - 1)); // obshtata duljina na kabela
            numberOfStudentCables = joinedCableLength / (500 + 2 + 2); // broq na kabelite, koito mojem da napravim
            remainder = joinedCableLength - (numberOfStudentCables * (500 + 2 + 2)); // ostatuka

            Console.WriteLine(numberOfStudentCables);
            Console.WriteLine(remainder);
        }
    }
}
