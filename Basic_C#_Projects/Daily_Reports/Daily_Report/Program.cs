using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("The Tech Academy\nStudent Daily Report\nWhat is your name?");
        string name = Console.ReadLine();//get the name of the student

        Console.WriteLine("What course are you on?");
        string course = Console.ReadLine();//ask for the course name

        Console.WriteLine("What page number?");
        short pageNumber = Convert.ToInt16(Console.ReadLine()); //used a short because I haven't seen any of the previous courses I've taken go over 1500 pages
        
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
        bool needHelp = Convert.ToBoolean(Console.ReadLine()); //ask if the student needs help. I was unable to find a way to add radio buttons to the console app.
        
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string posExp = Console.ReadLine();//ask the student if they had any positive experiences
        
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();//ask the student for feedback
        
        Console.WriteLine("How many hours did you study today?");
        sbyte hours = Convert.ToSByte(Console.ReadLine()); //decided to use sbyte because there are only 24 hours in a day and there isn't a smaller unit size
        
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shorly. Have a great day!");//final statement
        Console.ReadLine();//used to keep the program up
    }
}

