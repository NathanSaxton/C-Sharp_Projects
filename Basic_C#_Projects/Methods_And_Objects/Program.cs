using System;

namespace Methods_And_Objects
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };//instantiate an employee object
            employee.SayName();//call the inherited method from the employee object

            Console.ReadLine();
        }
    }
}
