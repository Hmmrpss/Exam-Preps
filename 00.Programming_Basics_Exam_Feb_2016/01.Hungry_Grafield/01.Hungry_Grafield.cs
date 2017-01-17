using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hungry_Grafield
{
    class Program
    {
        static void Main()
        {
            var givenSumOfMoney = float.Parse(Console.ReadLine());
            var exchangeRate = float.Parse(Console.ReadLine());
            var pizzaPrice = float.Parse(Console.ReadLine());
            var lasagnaPrice = float.Parse(Console.ReadLine());
            var sandwitchPrice = float.Parse(Console.ReadLine());
            var pizzaQuantity = int.Parse(Console.ReadLine());
            var lasagnaQuantity = int.Parse(Console.ReadLine());
            var sandwitchQuantity = int.Parse(Console.ReadLine());
            double allOfTheThings = (((pizzaPrice * pizzaQuantity) + (lasagnaPrice * lasagnaQuantity) + (sandwitchPrice * sandwitchQuantity)) * exchangeRate);
            //bool everythingIsAOK = (givenSumOfMoney >= allOfTheThings);

            if (givenSumOfMoney >= allOfTheThings)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", (givenSumOfMoney - allOfTheThings));
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", (allOfTheThings - givenSumOfMoney));
            }
        }
    }
} 
