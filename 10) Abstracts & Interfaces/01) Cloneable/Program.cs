using System;

namespace _01__Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {

            Student john = new Student("John Doe", 20, "male", "BME");

            Student JohnTheClone = (Student) john.Clone();      // object JohnTheClone = john.Clone();
            JohnTheClone.Introduce();                           // ((Student)JohnTheClone).Introduce();
        }

    }
}
