using System;

namespace HelloWorld.Intermediate.Exercises
{
    internal class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; }
        private int NumberOfVotes { get; set; }

        public int Rating => NumberOfVotes;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public void UpVote()
        {
            NumberOfVotes += 1;
        }

        public void DownVote()
        {
            NumberOfVotes -= 1;
        }
    }
}
