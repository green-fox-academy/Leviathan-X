using System;

namespace _13__Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reuse your BlogPost class
            // Create a Blog class which can
            // store a list of BlogPosts
            // add BlogPosts to the list
            // Delete(int) one item at given index
            // Update(int, BlogPost) one item at the given index and update it with another BlogPost

            Blog theBlog = new Blog();

            Blogpost post1 = new Blogpost("Lorem Ipsum", "John Doe", "\tLorem ipsum dolor sit amet.", "2000.05.04");
            theBlog.Add(post1);
            Blogpost post2 = new Blogpost("Wait but why", "Tim Urban", "\tA popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            theBlog.Add(post2);
            Blogpost post3 = new Blogpost("One Engineer Is Trying to Get IBM to Reckon With Trump", "William Turton", "\tDaniel Hanley, a cybersecurity engineer at IBM, " +
                "doesn’t want to be the center of attention.\n\tWhen I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t \n\t" +
                "really into the whole organizer profile thing.", "2017.03.28.");
            theBlog.Add(post3);

            theBlog.Print();
            
            Console.WriteLine("\n--------------------------------");

            theBlog.Delete(3);
            theBlog.Delete(2);

            theBlog.Print();

            Blogpost post4 = new Blogpost("Yoloooooo", "Jimmy McKenzie", "\tYo some latin stuff", "2020.02.02");

            Console.WriteLine("\n--------------------------------");

            theBlog.Update(1, post4);

            theBlog.Print();

        }
    }
}
