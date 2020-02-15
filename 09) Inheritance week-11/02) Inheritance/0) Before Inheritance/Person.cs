using System;
using System.Collections.Generic;
using System.Text;

namespace _0__Before_Inheritance
{
    class Person
    {
        private string name;
        private int age;
        private string gender;

        public Person(string Name, int Age, string Gender)
        {
            name = Name;
            age = Age;
            gender = Gender;
        }

        public void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender}.");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: \"Live for the moment!\"\n");
        }
    }
}
