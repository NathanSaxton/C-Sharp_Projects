using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 33, 23, 54, 32, 60, 74, 48 };
        Console.WriteLine("Please enter a number to divide the numbers in my list.");
        try //user entry following the loop through the list. 
        {
            int entry = Convert.ToInt32(Console.ReadLine());//get user input
            foreach (int number in numbers)//divide each integer in numbers by the user's entry
            {
                int result = number / entry;
                Console.WriteLine(number + " divided by " + entry + " equals " + result);
            }
        }
        catch (Exception ex)//generic exception errow with the error message following
        {
            Console.WriteLine("Something went wrong.\n" + ex.Message);
            return;
        }
        finally //run this no matter what
        {
            Console.WriteLine("We have successfully emerged from the try/catch block.");
            Console.ReadLine();
        }
    }
}

