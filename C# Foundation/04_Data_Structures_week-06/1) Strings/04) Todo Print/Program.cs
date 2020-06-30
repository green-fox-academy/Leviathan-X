using System;

namespace _04__Todo_Print
{
    class Program
    {
        static void Main(string[] args)
        {

            string todoText = " - Buy milk\n";
            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            
            todoText = todoText.Insert(0, "My todo: \n");
            // Console.WriteLine(todoText.IndexOf("milk"));
            todoText = todoText.Insert(22, " - Download games\n");
            // Console.WriteLine(todoText.IndexOf("games"));
            todoText = todoText.Insert(40, "\t - Diablo");


            Console.WriteLine(todoText);
        }
    }
}
