Console.Write("Enter your name: ");
var name = Console.ReadLine();
var usernames = new[] { "azizbek", "teshavoy-kosmonavt", "gayrat-app", "ali-production", "bekzod-pro" };
var words = new[] { "corporation", "pro", "production", "kosmonavt", "blog", "app" };
var wordsB = name.Split();

var username = string.Empty;
foreach (var word in wordsB)
{
    foreach (var v in word)
    {
        if ((v >= 'A' && v <= 'Z') || (v >= 'a' && v <= 'z'))
        {
            username += Convert.ToString(v).ToLower();
        }
    }
}


var rd = new Random();
var idx = rd.Next(0, words.Length);
username += $"-{words[idx]}";

while (true)
{
    if (usernames.Contains(username) == false)
    {
        Console.WriteLine($"Your username is : {username}");
        break;
    }
    else
    {
        username += rd.Next(1, 100);
    }
}