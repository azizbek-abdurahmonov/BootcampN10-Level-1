using System.Diagnostics.Tracing;

var second = 0;


var words = string.Empty;
while (true)
{
    words += Console.ReadKey().KeyChar.ToString();
    //Console.Clear();
    Console.WriteLine("bir ikki uch bir nimala yana nimadirlar");
    Console.WriteLine(words);
}
