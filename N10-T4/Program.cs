public class BlogPost
{
    public Guid Id;
    public string Title;
    public string Content;
    public string Tag;
    public int Likes;
    public int Dislikes;
}

public class BlogManager
{
    public void Analyze(List<BlogPost> blogposts)
    {
        foreach(var post in  blogposts)
        {
            var postTopics = post.Tag.Split(',');
            var uniqueTopics = new List<string>();
            foreach (var topic in postTopics)
            {
                if (!uniqueTopics.Contains(topic.Trim()))
                {
                    uniqueTopics.Add(topic.Trim());
                }
            }

            var topicContents = new Dictionary<string, List<string>>();
            foreach(var topic in postTopics)
            {
                if(!topicContents.ContainsKey(topic.Trim()))
                {
                    topicContents[topic.Trim()] = new List<string>();
                }
                topicContents[topic.Trim()].Add(post.Content);
            }


            foreach(var topic in uniqueTopics)
            {
                var likes = 0;
                var dislikes = 0;
                    
                foreach(var post in blogposts)
                {
                    if(post.Tag.Contains(topic.Trim()))
                    {
                        likes += post.Likes;
                        dislikes += post.Dislikes;
                    }
                }

                var rating = likes - dislikes;


            }
        }
    }
}