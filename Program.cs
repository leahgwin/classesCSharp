using System;
using System.Collections.Generic;

namespace classes
{
    // this is the custom type for Employee. the employee has the following properties:
    public class Employee
    {
        public string firstName { get; }
        public string lastName { get; }
        public string title { get; }
        public DateTime startDate { get; }
    }

    // this is the custom type for company. the company has the following properties:
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }

        // Create a public property for holding a list of current employees
        public List<Employee> currentEmployees = new List<Employee>();

        public void ListEmployees()
        {
            foreach (Employee employee in currentEmployees)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName} has the title, {employee.title}, and  started at the company on {employee.startDate}.");
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company Lyft = new Company()
            {
                Name = "Lyft",
                CreatedOn = DateTime.Now
            };

            // Create three employees

            // Assign the employees to the company

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
