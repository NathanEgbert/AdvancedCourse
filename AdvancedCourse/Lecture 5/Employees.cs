using System;
using System.Collections.Generic;
using System.Text;



namespace AdvancedCourse.Lecture_5
{
    public class Employees : IEmployee
    {
        private string firstName;

        private string lastName;

        private string employeeId;

        private string employeeType;

        private string salary;

        private string role;


        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string EmployeeID { get => employeeId; set => employeeId = value; }
        public string EmployeeType { get => employeeType; set => employeeType = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Role { get => role; set => role = value; }

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
