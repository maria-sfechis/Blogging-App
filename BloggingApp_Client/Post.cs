using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BloggingApp_Client
{
    public class Post
    {
        public int postId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Published { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public long CreatedAt { get; set; }
        public long UpdatedAt { get; set; }
        public Post() { }
        public Post(string title, string content, bool published)
        {
            Title = title;
            Content = content;
            Published = published;
        }
    }
}
