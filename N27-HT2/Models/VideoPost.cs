using N27_HT2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT2.Models
{
    internal class VideoPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public Topics Topic { get; set; }

        public VideoPost(string title, string description, int likes, int dislikes, Topics topic)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Likes = likes;
            Dislikes = dislikes;
            Topic = topic;
        }

        public override string ToString()
        {
            return $"{Title} {Description} {Likes} {Dislikes} {Topic}";
        }
    }
}
