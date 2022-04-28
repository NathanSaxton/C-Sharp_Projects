using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter \"true\" or \"false\" on the following questions.\nWhat is your age?");
        short age = Convert.ToInt16(Console.ReadLine()); //has user entry converted to a short
        Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\".");
        bool dui = Convert.ToBoolean(Console.ReadLine()); //converts user's entry to a bool
        Console.WriteLine("How many speeding tickets do you have?");
        short numberOfTickets = Convert.ToInt16(Console.ReadLine()); //again converts to be used as a short

        bool qualifies = age > 15 && dui == false && numberOfTickets <= 3; //confirms age is greater than 15, that dui is false, and number of tickets no more than 3

        Console.WriteLine("Qualifies?\n" + qualifies);
        Console.ReadLine();//used to pause the program so it doesn't close immediately
    }
}

