using System;
using System.Collections.Generic;
using System.Text;

namespace _0__Before_Inheritance
{
    class Sponsor
    {
        private string name;
        private int age;
        private string gender;
        private string company;
        private int hiredStudents;

        public Sponsor(string Name, int Age, string Gender, string Company)
        {
            name = Name;
            age = Age;
            gender = Gender;
            company = Company;
            hiredStudents = 0;
        }

        public void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: \"Hire brilliant junior software developers.\"\n");
        }
        public void Hire()
        {
            hiredStudents += 1;
        }

    }
}
