using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Local_Elections
{
    class Program
    {
        static void Main()
        {
            int numberOfCandidates = int.Parse(Console.ReadLine());
            int voteOfRazvigor = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfCandidates; i++)
            {
                Console.WriteLine(new string('.', 13));
                Console.WriteLine("...+-----+...");
                if (voteOfRazvigor == i)
                {
                    Console.WriteLine("...|.\\./.|...");
                    if (i >= 10)
                    {
                    Console.WriteLine("{0}.|..{1}..|...", i, symbol);
                    }
                    else
                    {
                        Console.WriteLine("0{0}.|..{1}..|...", i, symbol);     
                    } 
                    Console.WriteLine("...|./.\\.|...");
                }
                else
                {
                    Console.WriteLine("...|.....|...");
                   
                    if (i >= 10)
                    {
                    Console.WriteLine("{0}.|.....|...", i);
                    }
                    else
                    {
                        Console.WriteLine("0{0}.|.....|...", i);     
                    } 
                    Console.WriteLine("...|.....|...");
                }
                
                Console.WriteLine("...+-----+...");
            }
            Console.WriteLine(new string('.', 13));
        }
    }
}
