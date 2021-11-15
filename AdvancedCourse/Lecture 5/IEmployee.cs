using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCourse.Lecture_5
{
    public interface IEmployee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmployeeID { get; set; }

        public string EmployeeType { get; set; }

        public string Salary { get; set; }

        public string Role { get; set; }

    }
}
