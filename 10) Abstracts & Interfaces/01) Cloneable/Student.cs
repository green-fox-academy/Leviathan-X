using System;
using System.Collections.Generic;
using System.Text;

namespace _01__Cloneable
{
    class Student : Person, ICloneable
    {
        private string previousOrganization;
        int skippedDays;

        public Student(string Name, int Age, string Gender, string PreviousOrganization) : base(Name, Age, Gender)
        {
            previousOrganization = PreviousOrganization;
            skippedDays = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"\nHi, I'm {name}, a {age} year old {gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: \"Live for the moment!\"\n");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays = numberOfDays;
        }

        public object Clone()
        {
            return new Student (name, age, gender, previousOrganization);
            // return this; -- IS WRONG! If a variable in the clone is changed, so it will change in the original
        }
    }
}
