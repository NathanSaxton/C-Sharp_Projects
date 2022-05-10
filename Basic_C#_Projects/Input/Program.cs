using System;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number.");
            string entry = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Owner\Documents\starlog.txt", entry);

            Console.WriteLine(File.ReadAllText(@"C:\Users\Owner\Documents\starlog.txt"));
        }
    }
}
