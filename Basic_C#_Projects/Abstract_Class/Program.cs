using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { firstName = "Nathan", lastName = "Saxton" };//instantiate the employee class while using the person properties

            employee.SayName();//call the say name method

            IQuittable james = new Employee() { firstName = "James", lastName = "Martin" };//instantiate an IQuittable object using polymorphism

            james.Quit();//call the Quit method through the polymorphed object

            Console.ReadLine();
        }
    }
}
