using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public class Employee : Person//inherit from the person class
    {
        public override void SayName()//override the abstract method SayName
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
