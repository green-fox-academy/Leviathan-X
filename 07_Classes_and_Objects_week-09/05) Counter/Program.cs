using System;

namespace _05__Counter
{
    class Counter
    {
        private string name;
        private int num;
        public int Num
        {
            get
            {
                return 0;
            }
            set
            {
                num = value;
            }
        }
        public Counter(string name)
        {
            this.name = name;
            Console.WriteLine($"\nNew Counter with name \"{name}\" has been created.");
        }

        public void Add(int number)
        {
            this.num += number;
            Console.WriteLine($"\nValue of \"{number}\" has been added to {name}");
        }
        public string Get()
        {
            Console.WriteLine($"\nCurrent value of Counter {name} is {num}");
            return num.ToString();
        }
        public void Reset()
        {
            Console.WriteLine($"\nValue of Counter {name} has been reset.");
            num = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nWelcome to the Counter.\n\n");

            Counter new1 = new Counter("new1");
            new1.Get();

            new1.Num = 50;
            new1.Get();

            new1.Add(30);
            new1.Get();

            Counter new2 = new Counter("new2");
            new2.Get();
            new2.Num = 60;
            
            new2.Add(40);
            new2.Get();

            new1.Add(40);
            new1.Get();

            new1.Reset();
            new2.Reset();
        }
    }
}
