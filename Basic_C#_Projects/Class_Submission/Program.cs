using System;

namespace Class_Submission
{
    class Program
    {
        static void Main()
        {
            Class1 classius = new Class1();

            Console.WriteLine("Please enter a number.");
            int entry = Convert.ToInt32(Console.ReadLine());//get user's entry to divide by 2

            classius.Divide(entry);//pass the entry through the method that will divide by 2 and display the results


            int myNumber = Class1.Divide();//used the overloaded static method without any parameters
            Console.WriteLine("Here is another one that I did... " + myNumber);//displayed the results

            Console.ReadLine();
        }
    }
}
