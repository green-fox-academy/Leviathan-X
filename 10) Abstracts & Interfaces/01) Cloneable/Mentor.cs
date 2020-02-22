using System;
using System.Collections.Generic;
using System.Text;

namespace _01__Cloneable
{
    enum Level
    {
        junior,
        intermediate,
        senior
    }

    class Mentor : Person
    {
        private Level level;

        public Mentor(string Name, int Age, string Gender, Level Level) : base(Name, Age, Gender)
        {
            level = Level;
        }

        public override void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender} {level} mentor.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: \"Educate brilliant junior software developers.\"\n");
        }
    }
}
