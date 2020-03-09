using System;

namespace _09__TeachersAndStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Student and Teacher classes
            // Student
            //      Learn()->prints the student is learning something new
            //      Question(teacher)->calls the teachers answer method
            // Teacher
            //      Teach(student)->calls the students learn method
            //      Answer()->prints the teacher is answering a question
            // Instantiate a Student and Teacher object
            // Call the student's Question() method and the teacher's Teach() method

            Student student1 = new Student("Eric", "Cartman", "A1C");
            Teacher teacher1 = new Teacher("Herbert", "Garrison");

            student1.Question(teacher1);

            teacher1.Teach(student1);

        }
    }
}
