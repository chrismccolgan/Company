using System;
using System.Collections.Generic;

namespace Company
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> AllEmployees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string _name, DateTime _createdOn)
        {
            Name = _name;
            CreatedOn = _createdOn;
            AllEmployees = new List<Employee>();
        }
        public void AddEmployee(Employee anEmployee)
        {
            AllEmployees.Add(anEmployee);
        }
        public void ListEmployees()
        {
            foreach (Employee employee in AllEmployees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate.ToShortDateString()}");
            }
        }
    }
}