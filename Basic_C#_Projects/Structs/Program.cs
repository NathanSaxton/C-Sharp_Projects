using System;

namespace Structs
{
    class Program
    {
        static void Main()
        {
            Number number = new Number()//instantiate the Number struct
            {
                Amount = 516.1648m//assign a decimal to the amount
            };

            Console.WriteLine(number.Amount);//print the amount
            Console.ReadKey();
        }
    }
}
