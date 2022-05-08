using System;

namespace Parsing_Enums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the current day of the week.");
            string userInput = Console.ReadLine();

            try
            {
                DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);//take the user input and parse it to the Enum DaysOfTheWeek also works with number input

                Console.WriteLine(today);//write the day of the week that the user entered
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nPlease enter an actual day of the week");//write the exception message followed by the requested phrase
            }

            Console.ReadLine();
        }

        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
