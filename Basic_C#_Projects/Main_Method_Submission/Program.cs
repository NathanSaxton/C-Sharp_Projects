using System;

namespace Main_Method_Submission
{
    class Program
    {
        static void Main()
        {
            QuickAdd quick = new QuickAdd();//instantiate an instance of the QuickAdd Class
            int number = quick.Math(4);//use the first method
            Console.WriteLine("Here is a quick number: " + number);

            int results = quick.Math(48.2821m);//overloaded method 1
            Console.WriteLine("Here is another quick number: " + results);

            int anotherNumber = quick.Math("8");//overloaded method 2
            Console.WriteLine("Here is your last quick number: " + anotherNumber);

            Console.ReadLine();
            
        }
    }
}
