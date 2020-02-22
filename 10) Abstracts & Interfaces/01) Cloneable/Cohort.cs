using System;
using System.Collections.Generic;
using System.Text;

namespace _01__Cloneable
{
    class Cohort
    {
        private string name;
        List<Student> students;
        List<Mentor> mentors;

        public Cohort(string Name)
        {
            name = Name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"\nThe {name} cohort has {students.Count} students and {mentors.Count} mentors.\n");
        }
    }
}
