using System;

namespace _5__Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            const string userAdmin = "admin";
            const string passwordAdmin = "csharp";

            Console.WriteLine("Please enter your username: ");
            string loginUser = Console.ReadLine();
            Console.WriteLine("Please enter your password: ");
            string loginPassword = Console.ReadLine();


            if ((userAdmin == loginUser) && (passwordAdmin == loginPassword))
            {
                Console.Write("\nLogin successful. Welcome, Admin.\nChoose an option: \n" +
                    "1 - Restaurant menu\n" +
                    "2 - Tel. Contact on Banking Specialist\n" +
                    "Please write the number of your choice: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("\nWelcome to the Dead Rat Restaurant.\n" +
                            "Our menu: \n" +
                            "1 - Soups\n" +
                            "2 - Drinks\n" +
                            "Please write the number of your choice: ");
                        string foodchoice = Console.ReadLine();
                        switch (foodchoice)
                        {
                            case "1":
                                Console.WriteLine("SOUPS:\n1 - Bread Gulash\n2 - Bouillon with noodles");
                                break;
                            case "2":
                                Console.WriteLine("DRINKS:\n1 - Protein shake\n2 - Vodka");
                                break;
                            default:
                                Console.WriteLine("Invalid choice");
                                break;
                        }
                        break;
                    case "2":
                        Console.Write("\nSpecific banking specialist contact centre\n" +
                            "Are you already a customer of our bank? (yes/no): ");
                        string customer = Console.ReadLine();
                        Console.Write("\nWhat service are you looking for?\n" +
                            "1 - Mortgage\n" +
                            "2 - Savings Account\n" +
                            "3 - Shared Assets\n" +
                            "Please write the number of your choice: ");
                        string number = Console.ReadLine();

                        Console.Write("\nThe contact you are looking for is: +420 100");
                        if (customer == "yes")
                        {
                            Console.Write(" 200");
                        } else if (customer == "no")
                        {
                            Console.Write(" 300");
                        } else
                        {
                            Console.Write(" Error!");
                        }
                        switch (number)
                        {
                            case "1":
                                Console.Write(" 500\n");
                                break;
                            case "2":
                                Console.Write(" 600\n");
                                break;
                            case "3":
                                Console.Write(" 700\n");
                                break;
                            default:
                                Console.Write(" Error!\n");
                                break;
                        }
                        break;
                }


            } else if ((userAdmin == loginUser) && (passwordAdmin != loginPassword))
            {
                Console.WriteLine("\nInvalid Admin login.");
            } else
            {
                Console.Write("\nLogin successful. Welcome, User.\nChoose an option: \n" +
                    "1 - Log out\n" +
                    "2 - Log out\n" +
                    "Please write the number of your choice: ");
                Console.ReadLine();
                        
            }

            Console.WriteLine("\nHave a nice day.");

        }
    }
}
