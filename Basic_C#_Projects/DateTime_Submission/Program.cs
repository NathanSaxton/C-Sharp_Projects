using System;

namespace DateTime_Submission
{
    class Program
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today + "\nGive a number for the amount of hours we want to skip.");
            double userInput = Convert.ToInt32(Console.ReadLine());
            DateTime later = today.AddHours(userInput);
            Console.WriteLine("The new time is:\n" + later);
        }
    }
}
