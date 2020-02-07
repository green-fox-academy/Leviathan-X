using System;
using System.Collections.Generic;
using System.Text;

namespace _09__TeachersAndStudents
{
    class Teacher
    {
        private string firstName;
        private string lastName;

        public Teacher(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void Teach(Student student)
        {
            student.Learn();
        }
        public void Answer()
        {
            Console.WriteLine($"\nProfessor {lastName} answers a question.");
        }
    }
}
