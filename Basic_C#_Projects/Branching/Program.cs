using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease provide package weight.");
        short weight = Convert.ToInt16(Console.ReadLine());
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        } else
        {
            Console.WriteLine("Please provide package dimensions.\nWidth:");
            short width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Height:");
            short height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Length:");
            short length = Convert.ToInt16(Console.ReadLine());
            int dimensions = width + height + length;
            
            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
            } else
            {
                int quote = (width * height * length * weight)/100;
                Console.WriteLine("Your estimated total for shipping this package is $" + quote.ToString() + ".00\nThank you!");
                Console.ReadLine();
            }
        }
    }
}

