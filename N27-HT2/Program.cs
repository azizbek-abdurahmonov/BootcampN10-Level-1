using N27_HT2.Models;
using N27_HT2.Enums;
using System.Text.Json.Serialization;
using System.Text.Json;

var videoPosts = new List<VideoPost>
{
    new VideoPost("Funny Cat Compilation", "Watch these hilarious cats in action!", 25_000, 500, Topics.Fun),
    new VideoPost("Advanced Web Development Techniques", "Learn the latest web development tricks.", 10_000, 300, Topics.IT),
    new VideoPost("Epic Gaming Moments", "Witness incredible gaming highlights.", 50_000, 1_000, Topics.Gaming),
    new VideoPost("Entrepreneurial Success Stories", "Discover the secrets behind successful businesses.", 8_000, 200, Topics.Business),
    new VideoPost("How to Tell Jokes Like a Pro", "Master the art of delivering jokes.", 15_000, 1_500, Topics.Fun),
    new VideoPost("Cybersecurity Essentials", "Protect your online presence with these tips.", 12_000, 400, Topics.IT),
    new VideoPost("Speedrun: The Legend of Zara", "Watch the fastest playthrough of this classic game.", 30_000, 800, Topics.Gaming),
    new VideoPost("Investing in Stocks 101", "Learn the basics of stock market investment.", 7_000, 300, Topics.Business),
    new VideoPost("Stand-up Comedy Showcase", "Laugh out loud with these hilarious comedians.", 18_000, 2_000, Topics.Fun),
    new VideoPost("Creating User-Friendly UI/UX", "Design interfaces that users will love.", 14_000, 500, Topics.IT)
};

Console.WriteLine("Eng ko'p like olgani: ");
Console.WriteLine(videoPosts.MaxBy(x => x.Likes));
Console.WriteLine();

Console.WriteLine("Eng kam dislike olgani : ");
Console.WriteLine(videoPosts.MinBy(x => x.Dislikes));
Console.WriteLine();

Console.WriteLine("Likelar o'rtachasi: ");
Console.WriteLine(videoPosts.Average(x => x.Likes));
Console.WriteLine();

Console.WriteLine("Barcha videolardagi dislikelar soni: ");
Console.WriteLine(videoPosts.Sum(x => x.Dislikes));
Console.WriteLine();

Console.WriteLine("Videolar faqat title va desciption bilan: ");
var videosWithOnlyTitleAndDescription = videoPosts.Select(video => new { video.Title, video.Description }).ToList();
videosWithOnlyTitleAndDescription.ForEach(video => Console.WriteLine($"Title: {video.Title} | Description : {video.Description}"));
Console.WriteLine();

Console.WriteLine("videolardan topic bo'yicha unique qilib");
var topics = videoPosts.DistinctBy(x => x.Topic).ToList();
topics.ForEach(Console.WriteLine);
Console.WriteLine();

var grouped = videoPosts.GroupBy(
    video => video.Topic,
    (topic, videos) => new
    {
        Topic = topic,
        Videos = videos.ToList()
    }
    );

Console.WriteLine(JsonSerializer.Serialize(grouped));

