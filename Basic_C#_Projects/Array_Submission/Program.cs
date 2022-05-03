using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        Console.WriteLine("Pick a number 0-2 to get a new line.");
        short pick = Convert.ToInt16(Console.ReadLine());
        string[] lines = new string[3];//create the array followed by adding some items
        lines[0] = "They call me Stacy.";
        lines[1] = "That's not my....";
        lines[2] = "name!";
        if (pick > 3 || pick < 1)//prompt a message if they pick outside their options
        {
            Console.WriteLine("That number isn't an option. No line for you!");
        } else {
            Console.WriteLine(lines[pick]);//display their pick
        }

        Console.WriteLine("Now pick a number 0-4 to get a number");
        pick = Convert.ToInt16(Console.ReadLine()); //just reusing the variable from their previous pick
        int[] numbers = { 12, 31, 53, 58, 209};//created another array adding some items a different way
        if (pick > 5 || pick < 1)//prompt a message if they pick outside their options. 
        {
            Console.WriteLine("Sorry that's not an option. Last round coming up...");
        } else
        {
            Console.WriteLine("The number you picked was " + numbers[pick].ToString());//diplay their pick
        }

        Console.WriteLine("Last time let's pick a number from a list... pick a number 0-3.");
        List<string> newLines = new List<string>();//create the list and add items after
        newLines.Add("I'll run to you.");
        newLines.Add("Cambridge to Boston, this is the world you're lost in.");
        newLines.Add("Victim of compromise.");
        newLines.Add("You're a whistle in the catacombs. A paradox");
        pick = Convert.ToInt16(Console.ReadLine());//once again reusing the variable
        if(pick < 1 || pick > 4) //prompt a message if they pick anything outside of the list length
        {
            Console.WriteLine("Last I checked " + pick.ToString() + " was not a number between 0-3... game's over.");
        } else
        {
            Console.WriteLine("This is what someone said about you..." + newLines[pick]); //display their pick
        }
        Console.ReadLine();

    }
}

