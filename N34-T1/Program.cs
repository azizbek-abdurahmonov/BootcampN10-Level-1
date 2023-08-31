using System.Threading.Channels;

string path = @"D:\PROJECTS\BootcampN10-Level-1\N34-T1\text.txt";

var text = File.ReadAllText(path);

string wordB = string.Empty;
int max = default(int);

var words = text.Split();
foreach (var word in words)
{
    if (max < words.Count(x => x == word))
    {
        max = words.Count(x => x == word.Trim());
        wordB = word;
    }
}

Console.Write($"{wordB} so'zi {max} martta ishlatilgan");
