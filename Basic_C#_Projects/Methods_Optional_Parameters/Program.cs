using System;

namespace Methods_Optional_Parameters
{
    class Program
    {
        static void Main()
        {
            AnotherClass ssdd = new AnotherClass();
            Console.WriteLine("Please enter your first number:");
            int entry1 = Convert.ToInt32(Console.ReadLine());//get first input
            Console.WriteLine("You may enter a second number but it is completely optional.");
            int entry2;
            int result;

            if (int.TryParse(Console.ReadLine(), out entry2))//had to use TryParse to make the input optional. 
            {
                result = ssdd.AnotherDollar(entry1, entry2);//using the optional parameter
            } else
            {
                result = ssdd.AnotherDollar(entry1);//without using the optional parameter
            }
            Console.WriteLine("Here is the result: " + result);//display results



            Class2NameParams nameParams = new Class2NameParams();//created a new class and instantiated it

            nameParams.NameParams(numba1: 2, numba2: 3);//call the class method and specified the parameter's by name. 

            Console.ReadLine();
        }
    }
}
