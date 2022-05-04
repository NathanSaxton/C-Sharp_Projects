using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Submission
{
    public class Class1
    {
        public void Divide( int x)//void method used to divide by 2
        {
            x /= 2;
            Console.WriteLine("Your number divided by 2 equals: " + x);//Since we are not returning anything the results should be displayed before the method ends
        }
        public static int Divide()//created a method without parameters, overloaded it, and set it as static
        {
            int result = 10 / 2;

            return result;
        }
    }
}
