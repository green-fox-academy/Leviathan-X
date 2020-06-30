using System;
using System.Collections.Generic;

namespace _0__Before_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person person1 = new Person("Jane Doe", 30, "female");
            // person1.Introduce();
            // person1.GetGoal();

            // Student student1 = new Student("Jane Doe", 30, "female", "The School of Life");
            // student1.SkipDays(150);
            // student1.Introduce();
            // student1.GetGoal();

            // Mentor mentor1 = new Mentor("Jane Doe", 30, "female", Level.intermediate);
            // mentor1.Introduce();
            // mentor1.GetGoal();

            // Sponsor sponsor1 = new Sponsor("Jane Doe", 30, "female", "Google");
            // sponsor1.Hire();
            // sponsor1.Hire();
            // sponsor1.Introduce();
            // sponsor1.GetGoal();

            var people = new List<Person>();
            var students = new List<Student>();
            var mentors = new List<Mentor>();
            var sponsors = new List<Sponsor>();

            var mark = new Person("Mark", 46, "male");
            people.Add(mark);
            var jane = new Person("Jane Doe", 30, "female");
            people.Add(jane);
            var john = new Student("John Doe", 20, "male", "BME");
            students.Add(john);
            var apprentice = new Student("Jane Doe", 30, "female", "The School of Life");
            students.Add(apprentice);
            var gandhi = new Mentor("Gandhi", 148, "male", Level.senior);
            mentors.Add(gandhi);
            var teacher = new Mentor("Jane Doe", 30, "female", Level.intermediate);
            mentors.Add(teacher);
            var partner = new Sponsor("Jane Doe", 30, "female", "Google");
            sponsors.Add(partner);
            var elon = new Sponsor("Elon Musk", 46, "male", "SpaceX");
            sponsors.Add(elon);

            apprentice.SkipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }
            for (int i = 0; i < 3; i++)
            {
                partner.Hire();
            }

            foreach (var person in people)
            {
                person.Introduce();
                person.GetGoal();
            }

            foreach (var student in students)
            {
                student.Introduce();
                student.GetGoal();
            }

            foreach (var mentor in mentors)
            {
                mentor.Introduce();
                mentor.GetGoal();
            }

            foreach (var sponsor in sponsors)
            {
                sponsor.Introduce();
                sponsor.GetGoal();
            }


        }
    }
}
