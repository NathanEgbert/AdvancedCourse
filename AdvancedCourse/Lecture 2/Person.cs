using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCourse.Lecture_2
{
    class Person
    {

        private string name;
        private int age;
        private bool canWalk;

        public Person()
        {
            name = "Nate";
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.Age = age;

                if (age < 2 || age > 89)
                {
                    canWalk = false;
                }
                else
                {
                    canWalk = true;
                }
            }
        }

        public bool Equal(object obj)
        {
            try
            {
                var pObject = (Person)obj;
                if (obj.GetType() == typeof(Person))
                {
                    return pObject.age == this.age && pObject.name == this.name;
                }
                else
                {
                    throw new Exception("Type not person");
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
