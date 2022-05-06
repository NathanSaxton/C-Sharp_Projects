using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable//inherit from the person class and the IQuittable interface
    {
        public override void SayName()//override the abstract method SayName
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        public void Quit()//implement the Quit method from the interface. 
        {
            Console.WriteLine(firstName + " said they quit.");
        }

    }
}
