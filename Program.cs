using System;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company Acme = new Company("Acme, Inc.", DateTime.Now);

            // Create three employees
            Employee Joey = new Employee("Joey", "Tribbiani", "Chief Medical Officer", new DateTime(2018, 4, 23));
            Employee Chandler = new Employee("Chandler", "Bing", "IT Procurements Manager", new DateTime(2011, 11, 9));
            Employee Rachel = new Employee("Rachel", "Green", "Chief Fashion Officer", new DateTime(2014, 1, 15));

            // Assign the employees to the company
            Acme.AddEmployee(Joey);
            Acme.AddEmployee(Chandler);
            Acme.AddEmployee(Rachel);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            Acme.ListEmployees();
        }
    }
}