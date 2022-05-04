using System;

namespace Methods_Optional_Parameters
{
    class Program
    {
        static void Main()
        {
            AnotherClass ssdd = new AnotherClass();
            Console.WriteLine("Please enter your first number:");
            int entry1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You may enter a second number but it is completely optional.");
            int entry2;
            int result;

            if (int.TryParse(Console.ReadLine(), out entry2))
            {
                result = ssdd.AnotherDollar(entry1, entry2);
            } else
            {
                result = ssdd.AnotherDollar(entry1);
            }
            Console.WriteLine("Here is the result: " + result);

            Console.ReadLine();
        }
    }
}
