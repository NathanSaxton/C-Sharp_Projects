using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate:");
        int p1Rate = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Hours worked per week:");
        int p1Hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Person 2\nHourly Rate:");
        int p2Rate = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Hours worked per week:");
        int p2Hours = Convert.ToInt32(Console.ReadLine());

        int p1Annual = p1Rate * p1Hours * 52;
        int p2Annual = p2Rate * p2Hours * 52;

        Console.WriteLine("Annual salary of Person 1:\n" + p1Annual.ToString());
        Console.WriteLine("Annual salary of Person 2:\n" + p2Annual.ToString());
        Console.WriteLine("Does person 1 make more money than Person 2?");

        bool whoMakesMore = p1Annual > p2Annual;

        Console.WriteLine(whoMakesMore.ToString());
        Console.ReadLine();
    }
}

