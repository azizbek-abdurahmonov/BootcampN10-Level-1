using System.Net;
using System.Threading.Channels;
using N30_HT1.Services;


var path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();

var essay1 = Path.Combine(path, "essay1.txt");
File.Create(Path.Combine(essay1)).Close();

File.WriteAllText(essay1,
    @"Lorem ipsum dolor sit amet consectetur adipisicing elit. quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere, reiciendis voluptate maiores! Repellat, dolorum!");

var essayAnalyzer = new DocumentAnalyzerService();

var score = await essayAnalyzer.Analyze(essay1);
Console.WriteLine($"Score : {score}");

