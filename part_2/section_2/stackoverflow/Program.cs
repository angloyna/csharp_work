using System;

namespace stackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var title = "Help! My Computer Crashed";
            var description = "I was unplugging a bunch of cables from my wall, and now my computer won't start.";
            var post = new Post(title, description);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            System.Console.WriteLine(post.VoteCount);
            System.Console.WriteLine(post.CreatedAt);
        }
    }
}
