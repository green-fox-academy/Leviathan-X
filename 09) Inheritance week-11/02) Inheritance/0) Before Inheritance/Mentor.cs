using System;
using System.Collections.Generic;
using System.Text;

namespace _0__Before_Inheritance
{
    enum Level
    {
        junior,
        intermediate,
        senior
    }

    class Mentor
    {
        private string name;
        private int age;
        private string gender;
        private Level level;

        public Mentor(string Name, int Age, string Gender, Level Level)
        {
            name = Name;
            age = Age;
            gender = Gender;
            level = Level;
        }

        public void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender} {level} mentor.");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: \"Educate brilliant junior software developers.\"\n");
        }
    }
}
