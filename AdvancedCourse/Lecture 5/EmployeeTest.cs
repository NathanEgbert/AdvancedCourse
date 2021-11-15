using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NUnit.Framework;

namespace AdvancedCourse.Lecture_5
{
    public class EmployeeTest
    {
        Employees emp1 = new Employees("Nate", "Egbert", "123", "Permenant", "$123", "QA");
        Employees emp2 = new Employees("Bob", "E", "1234", "Temp", "$12", "Dev");
        Employees emp3 = new Employees("Tim", "R", "12345", "Temp", "$10", "Dev");

        [Test]
        public void EmployeeTest1()
        {
            List<Employees> employeeList = new List<Employees>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);

            var results = from emp in employeeList
                          where emp.FirstName.Equals("Nate")
                          where emp.Role.Equals("QA")
                          select emp;

            foreach(var empResult in results)
            {
                Console.Write("First Name is " + empResult.FirstName);
                Console.Write("Last Name is " + empResult.LastName);
                Console.Write("Salary is " + empResult.Salary);
                Console.Write("Role is " + empResult.Role);
            }
        }

    }
}
