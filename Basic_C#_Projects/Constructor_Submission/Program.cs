using System;

namespace Constructor_Submission
{
    class Program
    {
        static void Main()
        {
            const string pirateName = "Beakbeard";//set a const string
            
            var pirate1 = new Pirate(pirateName);//used const string to set a var using a chained constructor

            Console.WriteLine("{0} has {1} kills.", pirate1.Name, pirate1.KillCount);
            Console.ReadLine();
        }
    }
}
