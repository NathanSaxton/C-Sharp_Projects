using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number.");
        short number = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Turn " + number.ToString() +" into 10");
        if (number < 10) { //this will initiate the while loop
            while (number < 10) //set the condition
            {
                Console.WriteLine("Keep Growing!");//show that it's iterating through each time. 
                number++;//add a way to meet that condition
            }
            Console.WriteLine("The number you entered is now " + number.ToString());
        } else //this will initiate the do while loop
        {
            do
            {
                Console.WriteLine("It's too big it needs to shrink more!");//iterate through this
                number--;//while making changes
            } while (number > 10);//that will cause the number to meet this condition. 
            Console.WriteLine("The number you entered is now " + number.ToString());
        }
        Console.ReadLine();
    }
}

