// using System.Runtime.CompilerServices;
// using System.Text.Json;
// using LessonProject;
//
// var path = @"D:\PROJECTS\BootcampN10-Level-1\N25-Amaliyot1\AllCountries.txt";
// var jsonFile = File.ReadAllText(path);
//
//
// var result = JsonSerializer.Deserialize<List<Country>>(jsonFile);
//
// Console.WriteLine("Enter keyword: ");
// var filter = Console.ReadLine();
//
// result.Where(c => c.Region.Contains(filter, StringComparison.OrdinalIgnoreCase)).ToList().ForEach(c => Console.WriteLine(c.Region));


using VideoLibrary;

while (true)
{
    var dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    var videoURL = "https://www.youtube.com/watch?v=BF04dz7r9sk&list=RDBF04dz7r9sk&start_radio=1";
    var youtube = new YouTube();
    var video = youtube.GetVideo(videoURL);

    byte[] bytes = video.GetBytes();

    FileStream stream = new FileStream(Path.Combine(dir, video.FullName), FileMode.OpenOrCreate);
    stream.Write(bytes);
}