using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Nathan", LastName = "Saxton" };//instantiate the employee class while using the person properties

            employee.SayName();//call the say name method

            IQuittable james = new Employee() { FirstName = "James", LastName = "Martin" };//instantiate an IQuittable object using polymorphism

            james.Quit();//call the Quit method through the polymorphed object

            Console.ReadLine();
        }
    }
}
