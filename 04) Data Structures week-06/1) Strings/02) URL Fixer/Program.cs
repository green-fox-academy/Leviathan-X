using System;

namespace _02__URL_Fixer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Accidentally I got the wrong URL for a funny subreddit. It's probably "odds" and not "bots"
            // Also, the URL is missing a crucial component, find out what it is and insert it too!
            // Try to solve it more than once using different string functions!

            string url = "\nhttps//www.reddit.com/r/nevertellmethebots";

            url = url.Replace("bots", "odds");
            url = url.Insert(5, ":");

            Console.WriteLine(url);


        }
    }
}
