using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee() { firstName = "Nathan", lastName = "Saxton" };//instantiate the employee class while using the person properties

            employee.SayName();//call the say name method

            Console.ReadLine();
        }
    }
}
