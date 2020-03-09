using System;

namespace _14__Methods_and_Functions
{
    class Program
    {
        static void FirstMethodEver()
        {
            Console.WriteLine("\n'Sup.");
        }

        static int ReadNumber()
        {
            Console.Write("\nEnter your number: ");
            int number = Int32.Parse(Console.ReadLine());

            return number;
        }

        static int[] GetMarks()
        {
            Console.Write("Number of added marks: ");
            int marksNumber = Int32.Parse(Console.ReadLine());
            int[] marks = new int[marksNumber];

            for (int i = 0; i < marksNumber; i++)
            {
                Console.Write("{0}. mark: ", i + 1);
                marks[i] = Int32.Parse(Console.ReadLine());
            }
            return marks;
        }

        static int TotalMethod(int x, int y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {
            FirstMethodEver();

            int x = ReadNumber();
            Console.WriteLine("x = {0}", x);

            Console.WriteLine("\nEntering student marks list");
            int[] marksList = GetMarks();
            Console.Write("Given marks: ");
            for (int i = 0; i < marksList.Length; i++)
            {
                Console.Write("{0} ", marksList[i]);
            }

            Console.WriteLine("\n\nTotal of two numbers through a method.");
            Console.Write("1st number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("2nd number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            int total = TotalMethod(number1, number2);
            Console.WriteLine("{0} + {1} = {2}", number1, number2, total);

        }

    }
}
