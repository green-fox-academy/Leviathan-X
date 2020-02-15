using System;
using System.Collections.Generic;

namespace _01__Green_Fox_Organization
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var jane = new Person("Jane Doe", 30, "female");
            people.Add(jane);
            var john = new Student("John Doe", 20, "male", "BME");
            people.Add(john);
            var student = new Student("Jane Doe", 30, "female", "The School of Life");
            people.Add(student);
            var gandhi = new Mentor("Gandhi", 148, "male", Level.senior);
            people.Add(gandhi);
            var mentor = new Mentor("Jane Doe", 30, "female", Level.intermediate);
            people.Add(mentor);
            var sponsor = new Sponsor("Jane Doe", 30, "female", "Google");
            people.Add(sponsor);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            people.Add(elon);

            student.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }

            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            Cohort awesome = new Cohort("AWESOME");
            awesome.AddStudent(student);
            awesome.AddStudent(john);
            awesome.AddMentor(mentor);
            awesome.AddMentor(gandhi);
            awesome.Info();
        }
    }
}
