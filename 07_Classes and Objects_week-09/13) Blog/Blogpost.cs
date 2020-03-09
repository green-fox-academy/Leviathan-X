using System;
using System.Collections.Generic;
using System.Text;

namespace _13__Blog
{
    class Blogpost
    {
        string title;
        string authorName;
        string text;
        string publicationDate;

        public string AuthorName { get { return title; } private set {} }
        public string Title { get { return authorName; } private set {} }
        public string Text { get { return text; } private set {} }
        public string PublicationDate { get { return publicationDate; } private set {} }

        public Blogpost(string Title, string AuthorName, string Text, string PublicationDate)
        {
            this.title = Title;
            this.authorName = AuthorName;
            this.text = Text;
            this.publicationDate = PublicationDate;

            // Console.WriteLine($"\n\"{Title}\"\nTitled by {AuthorName}, posted at \"{PublicationDate}\"\n\n{Text}\n");
        }
    }
}
