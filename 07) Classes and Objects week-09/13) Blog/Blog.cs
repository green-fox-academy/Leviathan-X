using System;
using System.Collections.Generic;
using System.Text;

namespace _13__Blog
{
    class Blog
    {
        List<Blogpost> blogList;

        public Blog()
        {
            blogList = new List<Blogpost>();
        }

        public void Add(Blogpost blogpost)
        {
            blogList.Add(blogpost);
            Console.WriteLine($"-New blogpost by {blogpost.Title} created-");
        }

        public void Delete(int post)
        {
            post -= 1;
            Console.WriteLine($"\n-Blogpost n. {post+1} deleted-");
            blogList.RemoveAt(post);
        }

        public void Update(int post, Blogpost blogpost)
        {
            post -= 1;
            blogList.RemoveAt(post);
            blogList.Insert(post, blogpost);
        }

        public void Print()
        {
            for (int i = 0; i < blogList.Count; i++)
            {
                Console.WriteLine($"\n\"{blogList[i].AuthorName}\"\nWritten by {blogList[i].Title}, posted on \"{blogList[i].PublicationDate}\"\n\n{blogList[i].Text}\n");
            }
        }

    }
}
