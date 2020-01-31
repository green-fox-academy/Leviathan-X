using System;

namespace _02__BlogPost
{
    class Blogpost
    {
        string Title;
        string AuthorName;
        string Text;
        string PublicationDate;

        public Blogpost (string Title, string AuthorName, string Text, string PublicationDate)
        {
            this.Title = Title;
            this.AuthorName = AuthorName;
            this.Text = Text;
            this.PublicationDate = PublicationDate;

            Console.WriteLine($"\n\"{Title}\"\nTitled by {AuthorName}, posted at \"{PublicationDate}\"\n\n{Text}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create a BlogPost class that has
            // an authorName
            // a title
            // a text
            // a publicationDate

            // Create a few blog post objects:
            // "Lorem Ipsum" titled by John Doe posted at "2000.05.04."
            //      Lorem ipsum dolor sit amet.
            // "Wait but why" titled by Tim Urban posted at "2010.10.10."
            //      A popular long-form, stick-figure-illustrated blog about almost everything.
            // "One Engineer Is Trying to Get IBM to Reckon With Trump" titled by William Turton at "2017.03.28."
            //      Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention.
            //      When I asked to take his picture outside one of IBM’s New York City offices, he told me that he 
            //      wasn’t really into the whole organizer profile thing.

            Blogpost post1 = new Blogpost("Lorem Ipsum", "John Doe", "\tLorem ipsum dolor sit amet.", "2000.05.04");

            Blogpost post2 = new Blogpost("Wait but why", "Tim Urban", "\tA popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");

            Blogpost post3 = new Blogpost("One Engineer Is Trying to Get IBM to Reckon With Trump", "William Turton", "\tDaniel Hanley, a cybersecurity engineer at IBM, " +
                "doesn’t want to be the center of attention.\n\tWhen I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t \n\t" +
                "really into the whole organizer profile thing.", "2017.03.28.");

        }
    }
}
