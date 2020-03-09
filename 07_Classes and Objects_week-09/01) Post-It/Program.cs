using System;

namespace _01__Post_It
{
    class PostIt
    {
        string Name;
        string BackgroundColor;
        string Text;
        string TextColor;

        public PostIt(string Name, string BackgroundColor, string Text, string TextColor)
        {
            this.Name = Name;
            this.BackgroundColor = BackgroundColor;
            this.Text = Text;
            this.TextColor = TextColor;

            Console.WriteLine($"\n{Name}\nBackground Color: \t{BackgroundColor}\nText: \t\t\t{Text}\nText Color: \t\t{TextColor}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Create a PostIt a class that has:
            // a BackgroundColor
            // a Text on it
            // a TextColor
            // Create a few example post-it objects:
            // an orange with blue text: "Idea 1"
            // a pink with black text: "Awesome"
            // a yellow with green text: "Superb!"

            PostIt orange = new PostIt("Project1", "orange", "Idea 1", "blue");
            PostIt pink = new PostIt("Project2", "pink", "Awesome", "black");
            PostIt yellow = new PostIt("Project3", "yellow" , "Superb!", "green");
        }
    }
}
