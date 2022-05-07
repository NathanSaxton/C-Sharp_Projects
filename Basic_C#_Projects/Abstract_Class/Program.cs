using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee() { FirstName = "Nathan", LastName = "Saxton", Id = 6581684 };//instantiate the employee class while using the person properties
            Employee employee2 = new Employee() { FirstName = "Nate", LastName = "Saxton", Id = 6581684 };//instantiate a second employee
            employee1.SayName();//call the say name method

            IQuittable james = new Employee() { FirstName = "James", LastName = "Martin", Id = 6813516 };//instantiate an IQuittable object using polymorphism

            if (employee1 == employee2)
            {
                Console.WriteLine(employee1.FirstName + " and " + employee2.FirstName + " are the same person.");
            } else
            {
                Console.WriteLine(employee1.FirstName + " and " + employee2.FirstName + " ain't the same.");
            }

            james.Quit();//call the Quit method through the polymorphed object

            Console.ReadLine();
        }
    }
}
