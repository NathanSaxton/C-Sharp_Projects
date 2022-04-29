using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease provide package weight.");
        short weight = Convert.ToInt16(Console.ReadLine());
        if (weight > 50)//determine if the package is too heavy
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");//prompt before ending the program early
            Console.ReadLine();
        } else
        {
            Console.WriteLine("Please provide package dimensions.\nWidth:");
            short width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Height:");
            short height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Length:");
            short length = Convert.ToInt16(Console.ReadLine());
            int dimensions = width + height + length;//get the dimensions total
            
            if (dimensions > 50)//determine if the dimensions total is more than 50
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");//prompt before ending the program early
                Console.ReadLine();
            } else
            {
                int quote = (width * height * length * weight)/100;
                Console.WriteLine("Your estimated total for shipping this package is $" + quote.ToString() + ".00\nThank you!");//message for providing quote before ending the program
                Console.ReadLine();
            }
        }
    }
}

