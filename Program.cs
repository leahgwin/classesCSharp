using System;
using System.Collections.Generic;

namespace classes
{
    // this is the custom type for Employee. the employee has the following properties:
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public DateTime startDate { get; set; }
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

            Employee Leah = new Employee()
            {
                firstName = "Leah",
                lastName = "Gwin",
                startDate = DateTime.Now,
                title = "Social Media Associate"
            };

            Employee Hanna = new Employee()
            {
                firstName = "Hanna",
                lastName = "Cimperman",
                startDate = DateTime.Now,
                title = "Marketing Associate"
            };

            Employee Elise = new Employee()
            {
                firstName = "Elise",
                lastName = "Kelly",
                startDate = DateTime.Now,
                title = "Social Media Specialist"
            };

            // Assign the employees to the company
            Lyft.currentEmployees.Add(Leah);
            Lyft.currentEmployees.Add(Hanna);
            Lyft.currentEmployees.Add(Elise);

            Lyft.ListEmployees();

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
