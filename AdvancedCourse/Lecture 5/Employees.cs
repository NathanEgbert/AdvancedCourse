using System;
using System.Collections.Generic;
using System.Text;



namespace AdvancedCourse.Lecture_5
{
    public class Employees : IEmployee
    {
        private string role;


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public string Salary { get; set; }
        public string Role { get ; set ; }

        public Employees(string firstName, string lastName, string employeeId, string employeeType, string salary, string role)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeeID = employeeId;
            EmployeeType = employeeType;
            Salary = salary;
            Role = role;
        }
    }
}
