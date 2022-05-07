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
            Console.WriteLine(FirstName + " " + LastName);
        }
        
        public void Quit()//implement the Quit method from the interface. 
        {
            Console.WriteLine(FirstName + " said they quit.");
        }
        public static bool operator == (Employee employee1, Employee employee2)//overloading the == operator
        {
            return employee1.Id == employee2.Id;//return true if Id's match

        }

        public static bool operator != (Employee employee1, Employee employee2)//overloading the != operator
        {
            return employee1.Id != employee2.Id;//return true if Id's don't match
        }

        public override int GetHashCode()//added to remove errors per documentation
        {
            return 0;
        }

        public override bool Equals(object obj)//added to remove erros per documentation
        {
            return true;
        }
    }
}
