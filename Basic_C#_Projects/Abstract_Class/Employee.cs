using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class
{
    public class Employee : Person, IQuittable//inherit from the person class and the IQuittable interface
    {
        public int Id { get; set; }

        public override void SayName()//override the abstract method SayName
        {
            Console.WriteLine(firstName + " " + lastName);
        }
        
        public void Quit()//implement the Quit method from the interface. 
        {
            Console.WriteLine(firstName + " said they quit.");
        }
        public static Employee operator== (Employee employee1, Employee employee2)//overloading the == operator
        {
            if (employee1.Id == employee2.Id)
            {
                return employee1;//display employee1 if they are the same
            }
            else
            {
                return employee2;//display employee2 if they are different
            }

        }

        public static Employee operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                return employee2;//display employee2 if they are different
            } else
            {
                return employee1;//display employee1 if they are the same
            }
        }
    }
}
