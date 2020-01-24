using System;

namespace _05__Reverse
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            string str = new string(charArray);
            return str;
        }

        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverse(reversed));
        }
    }
}
