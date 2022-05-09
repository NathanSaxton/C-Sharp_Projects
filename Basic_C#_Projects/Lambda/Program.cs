using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "Thomas", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Joe", LastName = "Momma", Id = 86 };
            Employee employee3 = new Employee() { FirstName = "King", LastName = "James", Id = 15 };
            Employee employee4 = new Employee() { FirstName = "Mark", LastName = "Walberg", Id = 9 };
            Employee employee5 = new Employee() { FirstName = "Steven", LastName = "Thomas", Id = 5 };
            Employee employee6 = new Employee() { FirstName = "Stephen", LastName = "Grant", Id = 7 };
            Employee employee7 = new Employee() { FirstName = "Joey", LastName = "Dirt", Id = 11 };
            Employee employee8 = new Employee() { FirstName = "Marc", LastName = "Thomas", Id = 3 };
            Employee employee9 = new Employee() { FirstName = "Joseph", LastName = "Spectre", Id = 13 };
            Employee employee10 = new Employee() { FirstName = "Layla", LastName = "Greene", Id = 2 };

            List<Employee> employees = new List<Employee>()//after instantiating 10 employees add them to a list
            {
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10
            };
            
            List<Employee> joes = new List<Employee>();//create a new list that will add using a foreach loop
            
            foreach (Employee employee in employees)
            {
                if(employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee> newjoes = employees.Where(x => x.FirstName == "Joe").ToList();//new list where I add to it using lambda
            List<Employee> upperManagement = employees.Where(x => x.Id > 5).ToList();//new list where I add to it using lambda

            Console.WriteLine("Foreach loop:");//print results
            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName + " ID: " + joe.Id);
            }
            Console.WriteLine("\nLambda Loop:");

            foreach (Employee joe in newjoes)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName + " ID: " + joe.Id);
            }
            Console.WriteLine("\nID's above 5:");

            foreach (Employee officer in upperManagement)
            {
                Console.WriteLine(officer.FirstName + " " + officer.LastName + " ID: " + officer.Id);
            }

            Console.ReadLine();
        }
    }
}
