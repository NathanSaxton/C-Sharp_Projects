using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("User please enter a number to get some QuickMath done.");
            try
            {
                int entry = Convert.ToInt32(Console.ReadLine());
                QuickMath quickMath = new QuickMath();//instantiate the QuickMath class and assign it a variable name.

                int results = quickMath.Add(entry);//call the add method
                Console.WriteLine("Adding your number by itself equals: " + results);

                results = quickMath.Multiply(entry);//call the multiply method
                Console.WriteLine("Multiplying your number by itself equals: " + results);

                results = quickMath.Plus10(entry);//call the plus10 method
                Console.WriteLine("Your number plus 10 equals: " + results);
            }
            catch (Exception ex)//just incase
            {
                Console.WriteLine(ex.Message);
            }
            finally//Complete the program
            {
                Console.WriteLine("Thank you, come again.");
                Console.ReadLine();
            }
        }
    }
}
