using System;

namespace Company
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public Employee(string _firstName, string _lastName, string _title, DateTime _startDate)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Title = _title;
            StartDate = _startDate;
        }
    }
}