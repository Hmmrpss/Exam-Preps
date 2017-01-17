using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Perfect_Girlfriend
{
    class Program
    {
        static void Main()
        {
            int perfectGirls = 0;
            //string[,] data;
            //string input; 
            int dayScore;
            int telephoneNumberScore;
            int braSizeScore;
            int nameScore;
            string dayOfTheWeek;
            string name;
            int score = (dayScore + telephoneNumberScore + braSizeScore) - nameScore;
            input = Console.ReadLine();
            while (input != "Enough dates!")
	        {
                //girl ++;
                data[] = input.Split("\\", 3);
                input = Console.ReadLine();
	        }
           
            switch (dayOfTheWeek)
	        {
                case    "Monday":
                    dayScore = 1;
                    break;
                case    "Tuesday":
                    dayScore = 2;
                    break;
                case    "Wednesday":
                    dayScore = 3;
                    break;
                case    "Thursday":
                    dayScore = 4;
                    break;
                case    "Friday":
                    dayScore = 5;
                    break;
                case    "Saturday":
                    dayScore = 6;
                    break;
                case    "Sunday":
                    dayScore = 7;
                    break;
		        default:
	        }

            if (score >= 6000)
	        {
                 Console.WriteLine("{0} is perfect for you.", name);
	        }
            else
	        {
                Console.WriteLine("Keep searching, {0} is not for you.", name);  
	        }
            Console.WriteLine(perfectGirls);
        }
    }
}
