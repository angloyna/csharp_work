using System;

namespace stackoverflow
{
    public class Post
    {
        public string Title { get; }

        public string Description { get; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreatedAt = DateTime.Now;
        }

        public DateTime CreatedAt { get; }

        public int VoteCount { get; private set; }

        public void UpVote()
        {
            this.VoteCount++;

        }

        public void DownVote()
        {
            this.VoteCount--;
        }


    }
}