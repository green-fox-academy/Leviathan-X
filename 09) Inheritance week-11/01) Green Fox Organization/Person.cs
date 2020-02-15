using System;
using System.Collections.Generic;
using System.Text;

namespace _01__Green_Fox_Organization
{
    class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public Person(string Name, int Age, string Gender)
        {
            name = Name;
            age = Age;
            gender = Gender;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender}.");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: \"Live for the moment!\"\n");
        }
    }
}
