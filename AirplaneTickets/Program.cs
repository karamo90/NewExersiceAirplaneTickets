using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplaneTickets
{
    class Program
    {

        static void Main()
        {
            Greetings();

            City();

            MonthPrep();

            Date();

            AvailableSpace();

        }
        static void Greetings()
        {
            string welcome = "Welcome to our site";
            Console.WriteLine(welcome);
            Console.WriteLine("If you are lucky enough you can travel for one week from your selected date in England!");
        }
        static void Choices()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Here are our destinations for you to choose (please choose wisely): ");
            string[] city = { "1:Manchester", "2:Brendford", "3:Nottingham", "4:London" };
            foreach (string item in city)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------------------");

        }
        static int City()
        {
            Console.WriteLine("Give us your city of choice as above");
            string cityPrep;
            int cityPrep1;
            do
            {
                Choices();
                cityPrep = Console.ReadLine();
                cityPrep1 = Convert.ToInt32(cityPrep);
                if (cityPrep1 == 1)
                {
                    Console.WriteLine("You have chosen Manchester");
                    return cityPrep1;
                }
                else if (cityPrep1 == 2)
                {
                    Console.WriteLine("You have chosen Brendford");
                    return cityPrep1;
                }
                else if (cityPrep1 == 3)
                {
                    Console.WriteLine("You have chosen Nottingham");
                    return cityPrep1;
                }
                else if (cityPrep1 == 4)
                {
                    Console.WriteLine("You have chosen London");
                    return cityPrep1;
                }
            } while (cityPrep1 > 4 || cityPrep1 < 0);
            return cityPrep1;
        }

        static int MonthPrep()
        {
            Console.WriteLine("Give your month");
            string inputMonth;
            int month;
            do
            {
                inputMonth = Console.ReadLine();
                month = Convert.ToInt32(inputMonth);
                switch (month)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12: Console.WriteLine("Your month has 31 days");break;
                    case 2: Console.WriteLine("Your month has 28 days");break;
                    case 4: case 6: case 9: case 11: Console.WriteLine("Your month has 30 days");break;
                    default: Console.WriteLine("Wrong Input-Month please try again");break;
                }

            } while (month<0 ||month>12);
            return month;
        }
        static void Date()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Select between 1/1/2021-31/12-2021---Be one of the 100 that will travel to ENGLAND");
            Console.WriteLine("Give us the information in this format: DATE-MONTH-YEAR");

            string day1;
            int dayChoice;
            string month1;
            int monthChoice;
            string year1;
            int yearChoice;
            bool dayCondition;
            bool monthCondition;
            bool yearCondition;
            bool feb;
            bool mainCondition;
            int returnDay;
            do
            {

                day1 = Console.ReadLine();
                dayChoice = Convert.ToInt32(day1);
                month1 = Console.ReadLine();
                monthChoice = Convert.ToInt32(month1);
                year1 = Console.ReadLine();
                yearChoice = Convert.ToInt32(year1);
                int[] p = { dayChoice, monthChoice, yearChoice };
                returnDay = dayChoice + 7;
                dayCondition = (dayChoice > 0 && dayChoice <= 30);
                monthCondition = (monthChoice > 0 && monthChoice <= 12);
                yearCondition = (yearChoice == 2021);
                feb = monthChoice == 2 && dayChoice > 29;
                mainCondition = dayCondition && monthCondition && yearCondition;


                if (feb)
                {
                    Console.WriteLine("February cannot have more than 28 days");
                }
                else if (mainCondition)
                {
                    Console.WriteLine("Your input date is: " + dayChoice + "/" + monthChoice + "/" + yearChoice);
                }
                else
                {
                    Console.WriteLine("Wrong Date-Input try Again!");

                }
            } while (!mainCondition);
            Console.WriteLine("-----------------------------------------------");

        }
        static int Random(int min, int max)
        {
            Random a = new Random();
            return a.Next(min, max);

        }
        static int AvailableSpace()
        {
            int b = Random(0, 100);
            if (b > 0)
            {
                Console.WriteLine("Our available tickets are: " + b);
                Console.WriteLine("We are happy to anounce you that you can travel to your prefered destination!!!!!");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Thank for using our Site we hope you enjoy your staying in your destination!");
            }
            else
            {
                Console.WriteLine("Sorry try again next time!!");
            }

            return b;
        }
    }
}
