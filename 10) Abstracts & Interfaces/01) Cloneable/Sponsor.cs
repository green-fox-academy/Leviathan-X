using System;
using System.Collections.Generic;
using System.Text;

namespace _01__Cloneable
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string Name, int Age, string Gender, string Company) : base(Name, Age, Gender)
        {
            company = Company;
            hiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: \"Hire brilliant junior software developers.\"\n");
        }
        public void Hire()
        {
            hiredStudents += 1;
        }
    }
}
