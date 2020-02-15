using System;
using System.Collections.Generic;
using System.Text;

namespace _0__Before_Inheritance
{
    class Student
    {
        private string name;
        private int age;
        private string gender;
        private string previousOrganization;
        private int skippedDays;

        public Student(string Name, int Age, string Gender, string PreviousOrganization)
        {
            name = Name;
            age = Age;
            gender = Gender;
            previousOrganization = PreviousOrganization;
            skippedDays = 0;
        }

        public void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: \"Be a junior software developer.\"\n");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays = numberOfDays;
        }
    }
}
