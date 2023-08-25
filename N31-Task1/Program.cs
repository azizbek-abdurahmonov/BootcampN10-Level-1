using System.Diagnostics;
using System.Net.Mime;
using GoogleTranslateNET;
using GoogleTranslateNET.Objects.Translation;

while (true)
{
    var correctRes = new List<string> { "1", "2", "3", "4" };
    Console.WriteLine("1.Content download\n2.File translate\n3.Time\n4.Exit");
    var res = Console.ReadLine();
    if (!correctRes.Contains(res))
        Console.WriteLine("Nomalum buyruq");

    if (res == "4")
        break;
    else
    {
        switch (res)
        {
            case "1":
                var url = string.Empty;
                Console.WriteLine("Video linkini kiriting: ");
                url = Console.ReadLine();
                DownloadVideoAsync(url);
                // Task.Run(() => DownloadVideoAsync(url));
                Console.WriteLine("Video yuklanishni boshladi...");
                break;
            case "2":
                var text = string.Empty;
                Console.WriteLine("Text kiriting: ");
                text = Console.ReadLine();
                TranslateAsync(text);
                break;
        }
    }
}

async Task DownloadVideoAsync(string url)
{
    var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString(),
        "Downloads");
    // Console.WriteLine("Path : " + path);

    using (var httpClient = new HttpClient())
    {
        try
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var videoData = await httpClient.GetByteArrayAsync(url);
            // Console.WriteLine("Video bytelarga ajratildi :)");
            await File.WriteAllBytesAsync($"{path}/{Guid.NewGuid().ToString().Substring(0, 10)}.mp4", videoData);
            stopWatch.Stop();
            Console.WriteLine($"Video yuklandi!, ketgan vaqt : {stopWatch.Elapsed.Seconds}");
        }
        catch
        {
            Console.WriteLine("Video yuklash bilan nimadir xato ketdi!");
        }
    }
}

void TranslateAsync(string text)
{
    string url = "https://translate.google.com/?hl=ru&sl=en&tl=uz&text=method&op=translate";
    // var textForTranslate = string.Join("%20", text.Split());
    // url.Replace("method", textForTranslate);
    System.Diagnostics.Process.Start(url);
}