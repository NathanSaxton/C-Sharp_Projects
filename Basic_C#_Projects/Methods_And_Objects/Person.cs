using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_And_Objects
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()//void method to display the persons name
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
