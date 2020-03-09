using System;
using System.Collections.Generic;
using System.Text;

namespace _09__TeachersAndStudents
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string className;
        public Student(string firstName, string lastName, string className)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.className = className;
        }

        public void Learn()
        {
            Console.WriteLine($"\n{firstName} from {className} is learning something new.");
        } 

        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }
    }
}
